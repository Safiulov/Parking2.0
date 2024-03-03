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

namespace TESTREALISE.Формы
{
    public partial class Тарифы_и_услуги: Form
    {
        public  Тарифы_и_услуги()
        {
            InitializeComponent();
            
        }
        private async Task GetData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

            var response = await client.GetAsync("/api/Tarifs/all");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Tarifs>>();
                var result = data.OrderBy(t => t.Код_тарифа).ToList();

                // Отображение данных в таблице
                Тарифы.DataSource = new BindingList<Tarifs>(result);
            }
            else
            {
                MessageBox.Show("Не удалось получить данные");
            }
        }
        private async Task GetData2()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

            var response = await client.GetAsync("/api/Service/all");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Service>>();
                var result = data.OrderBy(t => t.Код_услуги).ToList();
                Услуги.DataSource = new BindingList<Service>(result);
            }
            else
            {
                MessageBox.Show("Не удалось получить данные");
            }
        }

        private async void Обновить_тариф_Click(object sender, EventArgs e)
        {
            if (Тарифы.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            var select_item = Тарифы.CurrentRow.Cells["Код_тарифа"].Value?.ToString();
            if (string.IsNullOrEmpty(select_item))
            {
                MessageBox.Show("Не удалось получить идентификатор записи.");
                return;
            }
            try
            {
                var klient = new Tarifs
                {

                    Название = Название_тарифа.Text,
                    Условие = Условие_тарифа.Text,
                    Время_действия = Единица_времени_тарифа.Text,
                    Стоимость = Convert.ToInt32(Стоимость_тарифа.Text)

                };

                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.PutAsJsonAsync($"/api/Tarifs/{select_item}", klient);

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

        private async void Обновить_услугу_Click(object sender, EventArgs e)
        {
            if (Услуги.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            var select_item = Услуги.CurrentRow.Cells["Код_услуги"].Value?.ToString();
            if (string.IsNullOrEmpty(select_item))
            {
                MessageBox.Show("Не удалось получить идентификатор записи.");
                return;
            }
            try
            {
                var klient = new Service
                {

                    Название = Название_услуги.Text,
                    Описание = Описание_услуги.Text,
                    Оплата = Оплата_услуги.Text,
                    Стоимость = Convert.ToInt32(Стоимость_услуги.Text)

                };

                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.PutAsJsonAsync($"/api/Service/{select_item}", klient);

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

        private void Тарифы_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in Тарифы.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                Название_тарифа.Text = row.Cells["Название"].Value.ToString();
                Условие_тарифа.Text = row.Cells["Условие"].Value.ToString();
                Единица_времени_тарифа.Text = row.Cells["Время_действия"].Value.ToString();
                Стоимость_тарифа.Text = row.Cells["Стоимость"].Value.ToString();

            }
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
                Название_услуги.Text = row.Cells["Название"].Value.ToString();
                Описание_услуги.Text = row.Cells["Описание"].Value.ToString();
                Оплата_услуги.Text = row.Cells["Оплата"].Value.ToString();
                Стоимость_услуги.Text = row.Cells["Стоимость"].Value.ToString();

            }
        }

        private void Тарифы_и_услуги_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && e.Control)
            {
                Обновить_тариф.PerformClick();// имитируем нажатие кнопки "Добавить запись"
            }
            if (e.KeyCode == Keys.R && e.Alt)
            {
                Обновить_услугу.PerformClick();// имитируем нажатие кнопки "Редактировать запись"
            }
            
        }

        private async void Тарифы_и_услуги_Load(object sender, EventArgs e)
        {
            await GetData();
            await GetData2();
        }
    }
}
