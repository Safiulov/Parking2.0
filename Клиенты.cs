using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTREALISE.Errors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TESTREALISE.Формы
{
    public partial class Клиенты : Form
    {

        public Клиенты()
        {
            InitializeComponent();
        }

        public async Task GetData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

            var response = await client.GetAsync("/api/Klients/All");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Klients>>();
                var result = data.OrderBy(t => t.Код_клиента).ToList();

                // Отображение данных в таблице
                Клиент.DataSource = new BindingList<Klients>(result);
            }
            else
            {
                MessageBox.Show("Не удалось получить данные");
            }
        }

        private async void Добавить_клиента_Click(object sender, EventArgs e)
        {
            try
            {
                var klient = new Klients
                {
                    ФИО = ФИО.Text,
                    Дата_рождения = Convert.ToDateTime(Дата_рождения.Text),
                    Телефон = Телефон.Text,
                    Логин = Логин.Text,
                    Пароль= Пароль.Text,
                    Код_авто= Convert.ToInt32(Код_авто.Text)
              
                };

                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.PostAsJsonAsync($"/api/Klients", klient);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Запись успешно добавлена");
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Ошибка: {errorMessage}");
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show($"Ошибка: {pe.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            await GetData();
            // Scroll to the last row
          
        }




        private async void Обновить_клиента_Click(object sender, EventArgs e)
        {
            if (Клиент.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            var select_item =Клиент.CurrentRow.Cells["Код_клиента"].Value?.ToString();
            if (string.IsNullOrEmpty(select_item))
            {
                MessageBox.Show("Не удалось получить идентификатор записи.");
                return;
            }

            try
            {
                var klient = new Klients
                {

                    ФИО = (ФИОр.Text),
                    Дата_рождения = Convert.ToDateTime(Дата_рожденияр.Text),
                    Телефон = Телефонр.Text,
                    Логин = Логин.Text,
                    Пароль = Пароль.Text


                };

                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.PutAsJsonAsync($"/api/Klients/{select_item}", klient);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Запись успешно обновлена");
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так...");
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Ошибка #" + pe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            await GetData();
        }

        private async void Удалить_клиента_Click(object sender, EventArgs e)
        {
            var select_item = Клиент.CurrentRow.Cells["Код_клиента"].Value.ToString();
           
            try
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.DeleteAsync($"/api/Klients/{select_item}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Запись успешно удалена");
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Ошибка: {errorMessage}");
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show($"Ошибка: {pe.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }

            await GetData();
        }

        private async void Удалить_всех_клиентов_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.DeleteAsync($"/api/Klients/Delete_All/");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Все записи успешно удалены");
                }
                else
                {
                    MessageBox.Show("Ошибка: " + await response.Content.ReadAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            await GetData();
        }

        private async void Поиск_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Критерии.Text))
                {
                    throw new Empty_value("Выберите критерий для поиска информации");
                }
                if (Значения.Text == string.Empty)
                {
                    throw new Empty_value($"Введите значение поиска в поле 'Значения' для поиска по критерию {Критерии.Text}");
                }
                var columnName = Критерии.SelectedItem.ToString();
                var columnValue = Значения.Text;
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта


                var response = await client.GetAsync($"/api/Klients/Search?columnName={columnName}&columnValue={columnValue}");

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Klients>>();
                    // Отображение данных в таблице
                    Клиент.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные");
                }
            }catch (Empty_value ev)
            {
                MessageBox.Show(ev.Message);
            }

        }


        private async void Показать_всех_клиентов_Click(object sender, EventArgs e)
        {
            await GetData();
        }


        internal void PageNavigation(System.Windows.Forms.MaskedTextBox btn) // перевод курсора ввода в начало textbox-а
        {
            if ((btn.Name == "Дата_рождения" && btn.MaskFull == false) || (btn.Name == "Телефон" && btn.MaskFull == false))
            {
                btn.Select(0, 0);
            }
        }
        public int currentPage = 0;

        private void Navigation() // Выбор textbox-а через switch-case
        {
            switch (currentPage)
            {
                case 1:
                    PageNavigation(Дата_рождения);
                    break;
                case 2:
                    PageNavigation(Телефон);
                    break;
                
            }
        }

        private void Дата_рождения_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            Navigation();
        }

        private void Телефон_Click(object sender, EventArgs e)
        {
            currentPage = 2;
            Navigation();
        }
      
        private void Клиенты_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I && e.Control)
            {
                Добавить_клиента.PerformClick();// имитируем нажатие кнопки "Добавить запись"
            }
            if (e.KeyCode == Keys.R && e.Control)
            {
                Редактирование_клиент.PerformClick();// имитируем нажатие кнопки "Редактировать запись"
            }
            if (e.KeyCode == Keys.D && e.Control)
            {
                Удалить_клиента.PerformClick();// имитируем нажатие кнопки "Удалить запись"
            }
            if (e.KeyCode == Keys.S && e.Control)
            {
                Показать_всех_клиентов.PerformClick();// имитируем нажатие кнопки "Показать все записи"
            }
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                Удалить_всех_клиентов.PerformClick();// имитируем нажатие кнопки "Удалить все записи"
            }
            if (e.KeyCode == Keys.F && e.Control)
            {
                Поиск.PerformClick();// имитируем нажатие кнопки "Поиск в БД"
            }
        }




        private void Клиент_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in Клиент.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                ФИОр.Text = row.Cells["ФИО"].Value.ToString();
                Дата_рожденияр.Text = row.Cells["Дата_рождения"].Value.ToString();
                Телефонр.Text = row.Cells["Телефон"].Value.ToString();

            }
        }

        private async void Клиенты_Load(object sender, EventArgs e)
        {
            await GetData();
        }

    }
}

        
    


