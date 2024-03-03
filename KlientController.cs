using Microsoft.AspNetCore.Mvc;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using WebApplication2.DB;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/Klients")]
    public class KlientController : Controller
    {
        private readonly IConfiguration _databaseService;

        public KlientController(IConfiguration configuration)
        {
            _databaseService = configuration;
        }

        [HttpGet]
        [Route("Search")]
        public async Task<IActionResult> Get(string columnName, string columnValue)
        {
            var result = new List<Klients>();

            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                await using (var command = new NpgsqlCommand($"SELECT * from \"Стоянка\".\"Klients\" WHERE cast({columnName} as text) like @columnValue;", connection))
                {
                   
                    command.Parameters.AddWithValue("@columnValue", $"%{columnValue}%");

                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var klients = new Klients
                            {
                                Код_клиента = await reader.GetFieldValueAsync<int>(0),
                                ФИО = await reader.GetFieldValueAsync<string>(1),
                                Дата_рождения = await reader.GetFieldValueAsync<DateTime>(2),
                                Телефон = await reader.GetFieldValueAsync<string>(3),
                                Логин = await reader.GetFieldValueAsync<string>(4),
                                Пароль = await reader.GetFieldValueAsync<string>(5),
                                Код_авто = await reader.GetFieldValueAsync<int>(6)

                            };

                            result.Add(klients);
                        }
                    }
                }
            }

            return Ok(result);
        }

        [HttpGet]
        [Route ("All")]
        public async Task<IActionResult> Get()
        {
            var result = new List<Klients>();

            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                await using (var command = new NpgsqlCommand("SELECT * FROM \"Стоянка\".\"Klients\";", connection))
                {
                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var klients = new Klients
                            {
                                Код_клиента = await reader.GetFieldValueAsync<int>(0),
                                ФИО = await reader.GetFieldValueAsync<string>(1),
                                Дата_рождения = await reader.GetFieldValueAsync<DateTime>(2),
                                Телефон = await reader.GetFieldValueAsync<string>(3),
                                Логин = await reader.GetFieldValueAsync<string>(4),
                                Пароль= await reader.GetFieldValueAsync<string>(5),
                                Код_авто = await reader.GetFieldValueAsync<int>(6)
                            };

                            result.Add(klients);
                        }
                    }
                }
            }

            return Ok(result);
        }






        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Klients klient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                await using (var command = new NpgsqlCommand("UPDATE \"Стоянка\".\"Klients\"\r\n\tSET \"ФИО\"=@ФИО, \"Код_авто\"=@Код_авто, \"Дата_рождения\"=@Дата_рождения, \"Телефон\"=@Телефон,\"Логин\"=@Логин,\"Пароль\"=@Пароль WHERE \"Код_клиента\" = @id;", connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("ФИО", klient.ФИО);
                    command.Parameters.AddWithValue("Дата_рождения", klient.Дата_рождения);
                    command.Parameters.AddWithValue("Телефон", klient.Телефон);
                    command.Parameters.AddWithValue("Логин", klient.Логин);
                    command.Parameters.AddWithValue("Пароль", klient.Пароль);
                    int rowsAffected = await command.ExecuteNonQueryAsync();

                    if (rowsAffected == 1)
                    {
                        return Ok();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Klients klient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();

               
                        await using (var command = new NpgsqlCommand("INSERT INTO \"Стоянка\".\"Klients\"(\"ФИО\", \"Дата_рождения\", \"Телефон\", \"Логин\", \"Пароль\",\"Код_авто\") VALUES (@ФИО, @Дата_рождения, @Телефон, @Логин, @Пароль,@Код_авто);", connection))
                        {
                           
                            command.Parameters.AddWithValue("ФИО", klient.ФИО);
                            command.Parameters.AddWithValue("Дата_рождения", klient.Дата_рождения);
                            command.Parameters.AddWithValue("Телефон", klient.Телефон);
                            command.Parameters.AddWithValue("Логин", klient.Логин);
                            command.Parameters.AddWithValue("Пароль", klient.Пароль);
                             command.Parameters.AddWithValue("Код_авто", klient.Код_авто);
                    int rowsAffected = await command.ExecuteNonQueryAsync();

                            if (rowsAffected == 1)
                            {
                                return Ok();
                            }
                            else
                            {
                                return BadRequest(ModelState);
                            }
                        }
                   
                   
                
            }
        }



        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                await using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        await using (var command = new NpgsqlCommand("DELETE FROM \"Стоянка\".\"Sales\" WHERE Код_клиента = @id;", connection, transaction))
                        {
                            command.Parameters.AddWithValue("id", id);
                            await command.ExecuteNonQueryAsync();
                        }

                        await using (var command = new NpgsqlCommand("DELETE FROM \"Стоянка\".\"Realisation\" WHERE Код_клиента = @id;", connection, transaction))
                        {
                            command.Parameters.AddWithValue("id", id);
                            await command.ExecuteNonQueryAsync();
                        }

                        await using (var command = new NpgsqlCommand("DELETE FROM \"Стоянка\".\"Klients\" WHERE Код_клиента = @id;", connection, transaction))
                        {
                            command.Parameters.AddWithValue("id", id);
                            await command.ExecuteNonQueryAsync();
                        }
                        transaction.Commit();
                        return Ok();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        return StatusCode(500, ex.Message);
                    }
                }
            }
        }




        [HttpDelete]
        [Route("Delete_All")]
        public async Task<IActionResult> DeleteAll()
        {
            string query = "ALTER SEQUENCE \"Стоянка\".\"Klients_Code_klient_seq\" RESTART WITH 0";
            await using (var connection = new NpgsqlConnection(_databaseService.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync();
                await using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        await using (var command = new NpgsqlCommand("DELETE FROM \"Стоянка\".\"Sales\" ", connection, transaction))
                        {
                            await command.ExecuteNonQueryAsync();
                        }
                        await using (var command = new NpgsqlCommand("DELETE FROM \"Стоянка\".\"Realisation\" ", connection, transaction))
                        {
                            await command.ExecuteNonQueryAsync();
                        }
                        await using (var command = new NpgsqlCommand("DELETE FROM \"Стоянка\".\"Klients\"", connection, transaction))
                        {
                            await command.ExecuteNonQueryAsync();
                        }
                        await using (var command = new NpgsqlCommand(query, connection, transaction))
                        {
                            await command.ExecuteNonQueryAsync();
                        }
                        transaction.Commit();
                        return Ok();
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        return StatusCode(500, ex.Message);
                    }
                }
            }
        }
    }
}
