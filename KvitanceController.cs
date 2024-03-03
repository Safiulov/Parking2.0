using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Reflection.PortableExecutable;
using WebApplication2.DB;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/Kvitance")]
    public class KvitanceController : Controller
    {
        private readonly IConfiguration _databaseService;
        public KvitanceController(IConfiguration configuration)
        {
            _databaseService = configuration;
        }


        [HttpGet]
        [Route("Search")]
        public async Task<IActionResult> GetInvoice(int clientCode)
        {
            var kvitance = new Kvitance();

            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();

                // Get client, auto, and stay information
                string sql = "select a.\"ФИО\", a.\"Дата_рождения\", a.\"Телефон\",b.\"Госномер\",b.\"Марка\", c.\"Дата_въезда\",c.\"Дата_выезда\" from \"Стоянка\".\"Klients\" a join \"Стоянка\".\"Sales\" c on a.\"Код_клиента\"=c.\"Код_клиента\" join \"Стоянка\".\"Auto\" b on a.\"Код_авто\" = b.\"Код_авто\" where a.\"Код_клиента\" =@clientCode";
                await using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("clientCode", clientCode);

                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            kvitance.ФИО = await reader.GetFieldValueAsync<string>(0);
                            kvitance.Дата_рождения = await reader.GetFieldValueAsync<DateTime>(1);
                            kvitance.Телефон = await reader.GetFieldValueAsync<string>(2);
                            kvitance.Госномер = await reader.GetFieldValueAsync<string>(3);
                            kvitance.Марка = await reader.GetFieldValueAsync<string>(4);
                            kvitance.Дата_въезда = await reader.GetFieldValueAsync<DateTime>(5);
                            kvitance.Дата_выезда = reader.IsDBNull(6) ? null : await reader.GetFieldValueAsync<DateTime>(6);
                        }
                        else
                        {
                            return NotFound("Клиент не найден.");
                        }
                    }
                }

                // Get services information
                sql = "select \"Название_услуги\",\"Сумма\" from \"Стоянка\".\"Realisation\" where \"Код_клиента\" =@clientCode";
                await using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("clientCode", clientCode);

                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        kvitance.Услуги = new List<Invoice>();
                        while (await reader.ReadAsync())
                        {
                            kvitance.Услуги.Add(new Invoice { Название = reader.GetString(0), Стоимость = reader.GetInt32(1) });
                            kvitance.Итого += reader.GetInt32(1);
                        }
                    }
                }
            }

            return Ok(kvitance);
        }

        [HttpGet]
        [Route("Free")]
        public async Task<IActionResult> Free()
        {
            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                connection.OpenAsync();

                string sql = "select a.\"Дата_въезда\",b.\"Марка\",b.\"Госномер\",c.\"ФИО\" from \"Стоянка\".\"Sales\" a join \"Стоянка\".\"Klients\" c on a.\"Код_клиента\"=c.\"Код_клиента\" join \"Стоянка\".\"Auto\" b on b.\"Код_авто\"=c.\"Код_авто\" where \"Дата_выезда\" is null";
                await using (var command = new NpgsqlCommand(sql, connection))
                {
                    var reports = new List<Report_of_free>();
                    await using (var reader = command.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            reports.Add(new Report_of_free
                            {
                                Дата_въезда = await reader.GetFieldValueAsync<DateTime>(0),
                                Марка = await reader.GetFieldValueAsync<string>(1),
                                Госномер = await reader.GetFieldValueAsync<string>(2),
                                ФИО = await reader.GetFieldValueAsync<string>(3)
                            });
                        }
                    }
                    return Ok(reports);
                }
            }
        }


        [HttpGet]
        [Route("Period")]
        public async Task<IActionResult> Period(DateTime date_in, DateTime date_out)
        {
            List<Period> period = new List<Period>();

            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();

                string sql = "SELECT r.\"Код_услуги\", s.\"Название\", r.\"Дата_въезда\", kl.\"ФИО\", kl.\"Телефон\", r.\"Сумма\" FROM \"Стоянка\".\"Realisation\" r JOIN \"Стоянка\".\"Service\" s ON r.\"Код_услуги\" = s.\"Код_услуги\" JOIN \"Стоянка\".\"Klients\" kl ON r.\"Код_клиента\" = kl.\"Код_клиента\" WHERE r.\"Дата_въезда\" BETWEEN @date_in AND @date_out GROUP BY r.\"Код_услуги\", s.\"Название\", r.\"Дата_въезда\", kl.\"ФИО\", kl.\"Телефон\",r.\"Сумма\" ORDER BY r.\"Дата_въезда\";";
                await using(var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("date_in", date_in);
                    command.Parameters.AddWithValue("date_out", date_out);
                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var report = new Period
                            {
                                Код_услуги = await reader.GetFieldValueAsync<int>(0),
                                Название = await reader.GetFieldValueAsync<string>(1),
                                Дата_въезда = await reader.GetFieldValueAsync<DateTime>(2),
                                ФИО = await reader.GetFieldValueAsync<string>(3),
                                Телефон = await reader.GetFieldValueAsync<string>(4),
                                Сумма = await reader.GetFieldValueAsync<int>(5)
                            };
                            period.Add(report);
                        }
                    }
                }
            }

            return Ok(period);
        }


    }
}
