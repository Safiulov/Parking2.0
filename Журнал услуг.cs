using MySqlX.XDevAPI.Common;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTREALISE.Errors;

namespace TESTREALISE.Формы
{
    public partial class Журнал_услуг : Form
    {
        public Журнал_услуг()
        {
            InitializeComponent();
            
        }


        private async Task GetData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

            var response = await client.GetAsync("/api/Realisation");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Realisation>>();
                var result = data.OrderBy(t => t.Код).ToList();

                // Отображение данных в таблице
                Услуги.DataSource = new BindingList<Realisation>(result); 
            }
            else
            {
                MessageBox.Show("Не удалось получить данные");
            }
        }

        private async void Добавить_Click(object sender, EventArgs e)
        {
            try
            {
                var klient = new Realisation
                {
                    Дата_въезда = Convert.ToDateTime(Дата_въезда.Text),
                    Место = Место.Text,
                    Код_услуги = Convert.ToInt32(Код_услуги.Text),
                    Код_клиента = Convert.ToInt32(Код_клиента.Text)

                };

                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.PostAsJsonAsync($"/api/Realisation/", klient);

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
        }

        private async void Удалить_всё_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.DeleteAsync($"/api/Realisation/");

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

        private async void Удалить_Click(object sender, EventArgs e)
        {
            var select_item = Услуги.CurrentRow.Cells["Код"].Value.ToString();

            try
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };
                var response = await client.DeleteAsync($"/api/Realisation/{select_item}");
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

        private async void Показать_все_записи_Click(object sender, EventArgs e)
        {
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


                var response = await client.GetAsync($"/api/Realisation/Search?columnName={columnName}&columnValue={columnValue}");

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Realisation>>();
                    var result = data.OrderBy(t => t.Код).ToList();
                    // Отображение данных в таблице
                    Услуги.DataSource = new BindingList<Realisation>(result);
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные");
                }
            }
            catch (Empty_value ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private async void Редактирование_услуги_Click(object sender, EventArgs e)
        {
            if (Услуги.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            var select_item = Услуги.CurrentRow.Cells["Код"].Value?.ToString();
            if (string.IsNullOrEmpty(select_item))
            {
                MessageBox.Show("Не удалось получить идентификатор записи.");
                return;
            }

            try
            {
                var klient = new Realisation
                {

                    Дата_въезда = Convert.ToDateTime(Дата_въездар.Text),
                    Место = Местор.Text,
                    Код_услуги = Convert.ToInt32(Код_услугир.Text),
                    Код_клиента = Convert.ToInt32(Код_клиентар.Text)

                };
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") }; 

                var response = await client.PutAsJsonAsync($"/api/Realisation/{select_item}", klient);

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



        private void Услуги_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in Услуги.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                Дата_въездар.Text = row.Cells["Дата_въезда"].Value.ToString();
                Местор.Text = row.Cells["Место"].Value.ToString();
                Код_услугир.Text = row.Cells["Код_услуги"].Value.ToString();
                Код_клиентар.Text = row.Cells["Код_клиента"].Value.ToString();

            }
        }

        internal void PageNavigation(MaskedTextBox btn) // перевод курсора ввода в начало textbox-а
        {
            if ((btn.Name == "Дата_въезда" && btn.MaskFull == false))
            {
                btn.Select(0, 0);
            }
        }

        private void Дата_въезда_Click(object sender, EventArgs e)
        {
            PageNavigation(Дата_въезда);
        }

        private void Журнал_услуг_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I && e.Control)
            {
                Добавить.PerformClick();// имитируем нажатие кнопки "Добавить запись"
            }
            if (e.KeyCode == Keys.R && e.Control)
            {
                Редактирование_услуги.PerformClick();// имитируем нажатие кнопки "Редактировать запись"
            }
            if (e.KeyCode == Keys.D && e.Control)
            {
                Удалить.PerformClick();// имитируем нажатие кнопки "Удалить запись"
            }
            if (e.KeyCode == Keys.S && e.Control)
            {
                Показать_все_записи.PerformClick();// имитируем нажатие кнопки "Показать все записи"
            }
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                Удалить_всё.PerformClick();// имитируем нажатие кнопки "Удалить все записи"
            }
            if (e.KeyCode == Keys.F && e.Control)
            {
                Поиск.PerformClick();// имитируем нажатие кнопки "Поиск в БД"
            }
        }

        private async void Журнал_услуг_Load(object sender, EventArgs e)
        {
            await GetData();
        }
    } 
}
