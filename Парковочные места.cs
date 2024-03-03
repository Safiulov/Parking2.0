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
    public partial class Парковочные_места : Form
    {
        public Парковочные_места()
        {
            InitializeComponent();
            
        }
        private async Task GetData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

            var response = await client.GetAsync("/api/Spaces/All");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Spaces>>();
                var result = data.OrderBy(t => t.Место).ToList();

                // Отображение данных в таблице
                Места.DataSource = new BindingList<Spaces>(result);
            }
            else
            {
                MessageBox.Show("Не удалось получить данные");
            }
        }

        private async void Добавить_место_Click(object sender, EventArgs e)
        {
            try
            {
                var klient = new Spaces
                {
                    Место = Название_места.Text,
                };

                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.PostAsJsonAsync($"/api/Spaces", klient);

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

        private async void Удалить_место_Click(object sender, EventArgs e)
        {
            var select_item = Места.CurrentRow.Cells["Место"].Value.ToString();

            try
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.DeleteAsync($"/api/Spaces/{select_item}");
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

        private async void Удалить_все_записи_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.DeleteAsync($"/api/Spaces/Delete_All/");

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


                var response = await client.GetAsync($"/api/Spaces/Search?columnName={columnName}&columnValue={columnValue}");

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Spaces>>();
                    // Отображение данных в таблице
                    Места.DataSource = data;
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
        private async void Показать_все_записи_Click(object sender, EventArgs e)
        {
            await GetData();
        }

        private void Парковочные_места_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I && e.Control)
            {
                Добавить_место.PerformClick();// имитируем нажатие кнопки "Добавить запись"
            }
            if (e.KeyCode == Keys.D && e.Control)
            {
                Удалить_место.PerformClick();// имитируем нажатие кнопки "Удалить запись"
            }
            if (e.KeyCode == Keys.S && e.Control)
            {
                Показать_все_записи.PerformClick();// имитируем нажатие кнопки "Показать все записи"
            }
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                Удалить_все_записи.PerformClick();// имитируем нажатие кнопки "Удалить все записи"
            }
            if (e.KeyCode == Keys.F && e.Control)
            {
                Поиск.PerformClick();// имитируем нажатие кнопки "Поиск в БД"
            }
        }

        private async void Парковочные_места_Load(object sender, EventArgs e)
        {
            await GetData();
        }
    }
}
