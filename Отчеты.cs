using Google.Protobuf;
using Newtonsoft.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Npgsql;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using BorderStyle = Spire.Doc.Documents.BorderStyle;
namespace TESTREALISE.Формы
{
    public partial class Отчеты : Form
    {
        public Отчеты()
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



        private async void button4_Click(object sender, EventArgs e)
        {
            // Get the list of selected row indices
            var selectedRows = Клиент.SelectedRows.Cast<DataGridViewRow>().Select(r => r.Index).ToList();

            // Create a list to store the unique selected rows
            var uniqueRows = new List<DataGridViewRow>();

            // Loop through the selected rows and add unique rows to the list
            foreach (var rowIndex in selectedRows)
            {
                var select = Клиент.Rows[rowIndex].Cells["Код_клиента"].Value.ToString();

                if (!uniqueRows.Any(r => r.Cells["Код_клиента"].Value.ToString() == select))
                {
                    uniqueRows.Add(Клиент.Rows[rowIndex]);
                }
            }

            // Loop through the unique rows and generate a report for each one
            foreach (var row in uniqueRows)
            {
                var select = row.Cells["Код_клиента"].Value.ToString();
                var name = row.Cells["ФИО"].Value.ToString();

                using (var client = new HttpClient())
                {
                    // Update the response variable for each iteration
                    var response = await client.GetAsync($"http://localhost:5100/api/Kvitance/Search?clientCode={select}");
                    var data = await response.Content.ReadAsStringAsync();

                    // Parse the response and extract the data needed for the report
                    var jsonData = JsonConvert.DeserializeObject<dynamic>(data);
                    string ФИО = jsonData.фио;
                    string Телефон = jsonData.телефон;
                    string Госномер = jsonData.госномер;
                    string Марка = jsonData.марка;
                    DateTime Дата_въезда = jsonData.дата_въезда;
                    DateTime? Дата_выезда = jsonData.дата_выезда;

                    // Create a new Docx document using a Spire template
                    Document document = new Document();
                    document.LoadFromFile("C:\\Temp\\Шаблон_квитанции.docx", FileFormat.Docx);

                    // Populate the report with the data from the REST API
                    document.Replace("#ФИО#", ФИО, false, true);
                    document.Replace("#Телефон#", Телефон, false, true);
                    document.Replace("#Госномер#", Госномер, false, true);
                    document.Replace("#Марка#", Марка, false, true);
                    document.Replace("#Дата_въезда#", Дата_въезда.ToString(), false, true);
                    document.Replace("#Дата_выезда#", Дата_выезда.ToString(), false, true);

                    var content = await response.Content.ReadAsStringAsync();
                    var data2 = JsonConvert.DeserializeObject<dynamic>(content);

                    Section section = document.Sections[0];
                    Table table = section.AddTable(true);

                    string[] columns = { "Услуга", "Стоимость" };
                    string[][] dataRows = new string[data2.услуги.Count][];
                    for (int i = 0; i < data2.услуги.Count; i++)
                    {
                        dataRows[i] = new string[] { data2.услуги[i].название.ToString(), data2.услуги[i].стоимость.ToString() };
                    }

                    // Create table cells and add data
                    table.ResetCells(dataRows.Length + 1, columns.Length);
                    TableRow row2 = table.Rows[0];
                    row2.IsHeader = true;
                    for (int i = 0; i < columns.Length; i++)
                    {
                        Paragraph p = row2.Cells[i].AddParagraph();
                        TextRange tr = p.AppendText(columns[i]);
                        tr.CharacterFormat.Bold = true;
                    }

                    for (int r = 0; r < dataRows.Length; r++)
                    {
                        TableRow dataRow = table.Rows[r + 1];
                        for (int c = 0; c < columns.Length; c++)
                        {
                            Paragraph p = dataRow.Cells[c].AddParagraph();
                            TextRange tr = p.AppendText(dataRows[r][c]);
                        }
                    }

                    // Add a row for "Итого" and the sum of the "Sum" column to the table
                    TableRow totalRow = table.AddRow(true);
                    totalRow.Cells[0].AddParagraph().AppendText("Итого");
                    var totalSum = 0;
                    foreach (var service in data2.услуги)
                    {
                        totalSum += (int)service.стоимость;
                    }
                    totalRow.Cells[1].AddParagraph().AppendText(totalSum.ToString());

                    // Save the table to the document
                    section.Tables.Add(table);

                    // Save the report as a Docx file
                    document.SaveToFile($"C://Temp//Клиент_{name}.docx", FileFormat.Docx);
                }
            }

            MessageBox.Show("Reports generated successfully!");
        }





        private async void button5_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"http://localhost:5100/api/Kvitance/Free").Result;
                var content = await response.Content.ReadAsStringAsync();
                var data = JArray.Parse(content);

                Section section = document.AddSection();
                Table table = section.AddTable(true);

                string[] columns = { "ФИО", "Госномер", "Марка", "Дата_въезда" };
                string[][] dataRows = new string[data.Count][];

                for (int r = 0; r < data.Count; r++)
                {
                    JObject row2 = (JObject)data[r];
                    dataRows[r] = new string[] { row2["фио"].ToString(), row2["госномер"].ToString(), row2["марка"].ToString(), row2["дата_въезда"].ToString() };
                }

                // Create table cells and add data
                table.ResetCells(dataRows.Length + 1, columns.Length);
                TableRow row = table.Rows[0];
                row.IsHeader = true;
                for (int i = 0; i < columns.Length; i++)
                {
                    Paragraph p = row.Cells[i].AddParagraph();
                    TextRange tr = p.AppendText(columns[i]);
                    tr.CharacterFormat.Bold = true;
                }

                for (int r = 0; r < dataRows.Length; r++)
                {
                    TableRow dataRow = table.Rows[r + 1];
                    for (int c = 0; c < columns.Length; c++)
                    {
                        Paragraph p = dataRow.Cells[c].AddParagraph();
                        TextRange tr = p.AppendText(dataRows[r][c]);
                    }
                }

                // Save the table to the document
                section.Tables.Add(table);

                // Save the report as a Docx file
                document.SaveToFile("C://Temp//Занятые места.docx", FileFormat.Docx);
                MessageBox.Show("OK");

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            Document document = new Document();
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"http://localhost:5100/api/Kvitance/Period?date_in={dateTimePicker1.Value}&date_out={dateTimePicker2.Value}").Result;
                var content = await response.Content.ReadAsStringAsync();
                var data = JArray.Parse(content);

                Section section = document.AddSection();
                Table table = section.AddTable(true);

                string[] columns = { "Код_услуги", "Название", "Дата_въезда", "ФИО", "Телефон", "Сумма" };
                string[][] dataRows = new string[data.Count][];

                for (int r = 0; r < data.Count; r++)
                {
                    JObject row2 = (JObject)data[r];
                    dataRows[r] = new string[] { row2["код_услуги"].ToString(), row2["название"].ToString(), row2["дата_въезда"].ToString(), row2["фио"].ToString(), row2["телефон"].ToString(), row2["сумма"].ToString() };
                }

                // Create table cells and add data
                table.ResetCells(dataRows.Length + 1, columns.Length);
                TableRow row = table.Rows[0];
                row.IsHeader = true;
                for (int i = 0; i < columns.Length; i++)
                {
                    Paragraph p = row.Cells[i].AddParagraph();
                    TextRange tr = p.AppendText(columns[i]);
                    tr.CharacterFormat.Bold = true;
                }

                for (int r = 0; r < dataRows.Length; r++)
                {
                    TableRow dataRow = table.Rows[r + 1];
                    for (int c = 0; c < columns.Length; c++)
                    {
                        Paragraph p = dataRow.Cells[c].AddParagraph();
                        TextRange tr = p.AppendText(dataRows[r][c]);
                    }
                }

                TableRow totalRow = table.AddRow(true);
                totalRow.Cells[0].AddParagraph().AppendText("Итого");
                var totalSum = 0;
                foreach (var service in data)
                {
                    totalSum += (int)service["сумма"];
                }
                totalRow.Cells[5].AddParagraph().AppendText(totalSum.ToString());

                // Save the table to the document
                section.Tables.Add(table);

                // Save the report as a Docx file
                document.SaveToFile("C://Temp//Услуги за период.docx", FileFormat.Docx);
                MessageBox.Show("OK");

            }

        }

        private async void Отчеты_Load(object sender, EventArgs e)
        {
            await GetData();
        }
    }
}
