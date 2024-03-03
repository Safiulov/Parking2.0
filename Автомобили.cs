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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TESTREALISE.Формы
{
    public partial class Автомобили : Form
    {
        public Автомобили()
        {
            InitializeComponent();
            
        }


        private async Task GetData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

            var response = await client.GetAsync("/api/Auto");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Auto>>();
                var result = data.OrderBy(t => t.Код_авто).ToList();

                // Отображение данных в таблице
                Автомобиль.DataSource = new BindingList<Auto>(result); // Assuming Автомобиль is a DataGridView

                // Optionally handle UI update on the UI thread
                //Invoke((MethodInvoker)delegate { Автомобиль.DataSource = new BindingList<Auto>(result); });
            }
            else
            {
                MessageBox.Show("Не удалось получить данные");
            }
        }



        private async void Добавление_авто_Click(object sender, EventArgs e)
        {
            try
            {
                var klient = new Auto
                {
                    Марка = Марка.Text,
                    Цвет = Цвет.Text,
                    Тип = Тип.Text,
                    Госномер = Госномер.Text,
                    Год = Convert.ToInt32(Год_выпуска.Text),
                   
                };

                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.PostAsJsonAsync("/api/Auto", klient);

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
            if (Автомобиль.DisplayedRowCount(true) > 0)
            {
                int lastRowIndex = Автомобиль.Rows.Count - 1;
                if (lastRowIndex >= 0 && lastRowIndex < Автомобиль.Rows.Count)
                {
                    Автомобиль.FirstDisplayedScrollingRowIndex = lastRowIndex;
                }
            }
            Автомобиль.CurrentCell = null;
            Автомобиль.Rows[Автомобиль.Rows.Count - 1].Selected = true;
        }

        private async void Удалить_авто_Click(object sender, EventArgs e)
        {
            var select_item = Автомобиль.CurrentRow.Cells["Код_авто"].Value.ToString();

            try
            {
                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.DeleteAsync($"/api/Auto/{select_item}");

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

        private async void Удалить_все_авто_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5100"); // Введите адрес вашего первого проекта

                var response = await client.DeleteAsync($"/api/Auto/Delete_All/");

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


                var response = await client.GetAsync($"/api/Auto/Search?columnName={columnName}&columnValue={columnValue}");

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Auto>>();
                    // Отображение данных в таблице
                    Автомобиль.DataSource = data;
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

        private async void Редактирование_авто_Click(object sender, EventArgs e)
        {
            if (Автомобиль.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            var select_item = Автомобиль.CurrentRow.Cells["Код_авто"].Value?.ToString();
            if (string.IsNullOrEmpty(select_item))
            {
                MessageBox.Show("Не удалось получить идентификатор записи.");
                return;
            }

            try
            {
                var klient = new Auto
                {
                    Марка = Маркар.Text,
                    Цвет = Цветр.Text,
                    Тип = Типр.Text,
                    Госномер = Гос_номерр.Text,
                    Год = Convert.ToInt32(Год_выпускар.Text)
                };

                var client = new HttpClient { BaseAddress = new Uri("http://localhost:5100") };

                var response = await client.PutAsJsonAsync($"/api/Auto/{select_item}", klient);

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
    

        private void Автомобиль_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in Автомобиль.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                Маркар.Text = row.Cells["Марка"].Value.ToString();
                Цветр.Text = row.Cells["Цвет"].Value.ToString();
                Типр.Text = row.Cells["Тип"].Value.ToString();
                Гос_номерр.Text = row.Cells["Госномер"].Value.ToString();
                Год_выпускар.Text = row.Cells["Год"].Value.ToString();

            }
        }

      
        private void Автомобили_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I && e.Control)
            {
                Добавление_авто.PerformClick();// имитируем нажатие кнопки "Добавить запись"
            }
            if (e.KeyCode == Keys.R && e.Control)
            {
                Редактирование_авто.PerformClick();// имитируем нажатие кнопки "Редактировать запись"
            }
            if (e.KeyCode == Keys.D && e.Control)
            {
                Удалить_авто.PerformClick();// имитируем нажатие кнопки "Удалить запись"
            }
            if (e.KeyCode == Keys.S && e.Control)
            {
                Показать_все_авто.PerformClick();// имитируем нажатие кнопки "Показать все записи"
            }
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                Удалить_все_авто.PerformClick();// имитируем нажатие кнопки "Удалить все записи"
            }
            if (e.KeyCode == Keys.F && e.Control)
            {
                Поиск.PerformClick();// имитируем нажатие кнопки "Поиск в БД"
            }
        }


        private void PageNavigate(MaskedTextBox masked)
        {
            if ((masked.Name == "Год_выпуска" && masked.MaskFull == false))
            {
                masked.Select(0, 0);
            }
        }
      

        private void Год_выпуска_Click(object sender, EventArgs e)
        {
           PageNavigate(Год_выпуска);
        }

        private async void Показать_все_авто_Click(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void Автомобили_Load(object sender, EventArgs e)
        {
            await GetData();
        }
    }
}
