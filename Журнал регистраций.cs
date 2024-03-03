using K4os.Compression.LZ4;
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
    public partial class Журнал_регистраций : Form
    {
        public Журнал_регистраций()
        {
            InitializeComponent();
            
        }

        private async Task GetData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

            var response = await client.GetAsync("/api/Sales ");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Sales>>();
                var result = data.OrderBy(t => t.Код).ToList();

                // Отображение данных в таблице
                Регистрации.DataSource = new BindingList<Sales>(result);
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
                var klient = new Sales
                {
                    Дата_въезда = Convert.ToDateTime(Дата_въезда.Text),
                    Место = Место.Text,
                    Код_клиента = Convert.ToInt32(Код_клиента.Text)

                };
                if (string.IsNullOrEmpty(Дата_выезда.Text))
                {
                    klient.Дата_выезда = null;
                }
                else
                {
                    DateTime date;

                    if (DateTime.TryParse(Дата_выезда.Text, out date))
                    {
                        klient.Дата_выезда= date;
                    }
                }
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.PostAsJsonAsync($"/api/Sales", klient);

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
                MessageBox.Show("Ошибка #" + pe.Message);

            }
            await GetData();
        }

        private async void Удалить_всё_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.DeleteAsync($"/api/Sales/");

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
            var select_item = Регистрации.CurrentRow.Cells["Код"].Value.ToString();

            try
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.DeleteAsync($"/api/Sales/{select_item}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Запись успешно удалена");
                }
                else
                {
                    MessageBox.Show("NO");
                }

            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Ошибка #" + pe.Message);

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


                var response = await client.GetAsync($"/api/Sales/Search?columnName={columnName}&columnValue={columnValue}");

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Sales>>();
                    // Отображение данных в таблице
                    Регистрации.DataSource = data;
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

        private async void Редактирование_регистрации_Click(object sender, EventArgs e)
        {
            if (Регистрации.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            var select_item = Регистрации.CurrentRow.Cells["Код"].Value?.ToString();
            if (string.IsNullOrEmpty(select_item))
            {
                MessageBox.Show("Не удалось получить идентификатор записи.");
                return;
            }

            try
            {
                var klient = new Sales
                {

                    Дата_въезда = Convert.ToDateTime(Дата_въездар.Text),
                    Дата_выезда = Convert.ToDateTime(Дата_выездар.Text),
                    Место = Местор.Text,
                    Код_клиента = Convert.ToInt32(Код_клиентар.Text)

                };

                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.PutAsJsonAsync($"/api/Sales/{select_item}", klient);
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

        private async void Показать_все_записи_Click(object sender, EventArgs e)
        {
            await GetData();
        }

        internal void PageNavigation(MaskedTextBox btn) // перевод курсора ввода в начало textbox-а
        {
            if ((btn.Name == "Дата_въезда" && btn.MaskFull == false) || (btn.Name == "Дата_выезда" && btn.MaskFull == false))
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
                    PageNavigation(Дата_въезда);
                    break;
                case 2:
                    PageNavigation(Дата_выезда);
                    break;
            }
        }

        private void Дата_въезда_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            Navigation();
        }

        private void Дата_выезда_Click(object sender, EventArgs e)
        {
            currentPage = 2;
            Navigation();
        }

        private void Регистрации_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in Регистрации.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                Дата_въездар.Text = row.Cells["Дата_въезда"].Value.ToString();
                Дата_выездар.Text = row.Cells["Дата_выезда"].Value == null ? "" : row.Cells["Дата_выезда"].Value.ToString();
                Местор.Text = row.Cells["Место"].Value.ToString();
                Код_клиентар.Text = row.Cells["Код_клиента"].Value.ToString();

            }
        }

        private void Журнал_регистраций_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I && e.Control)
            {
                Добавить.PerformClick();// имитируем нажатие кнопки "Добавить запись"
            }
            if (e.KeyCode == Keys.R && e.Control)
            {
                Редактирование_регистрации.PerformClick();// имитируем нажатие кнопки "Редактировать запись"
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

        private async void Журнал_регистраций_Load(object sender, EventArgs e)
        {
            await GetData();
        }
    }
}
