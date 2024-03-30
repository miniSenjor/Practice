using System;
using System.Data;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Configuration;

namespace Practika
{
    internal class DB
    {
        /// <summary>
        /// Функция для обновления таблицы DataGridView
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="dvg">DataGridView</param>
        /// <returns></returns>
        public DataTable SqlReturnData(string query, Guna2DataGridView dvg)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString))
                {
                    connection.Open();
                    if (connection.State != ConnectionState.Open)
                    {
                        FormErrorShowDialog formErr = new FormErrorShowDialog("Не удалось подключиться к бд", "Ошибка");
                        formErr.ShowDialog();
                        return null;
                    }

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dvg.DataSource = dt;
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла ошибка при выполнении запроса {ex.Message}", "Ошибка");
                formErr.ShowDialog();
                return null;
            }
            catch (Exception ex) 
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла непредвиденная ошибка {ex.Message}", "Ошибка");
                formErr.ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Поиск значений в базе данных
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="answer">Ответ</param>
        /// <returns></returns>
        public string ReturnStringValue(string query, out string answer)
        {
            answer = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString))
                {
                    connection.Open();
                    if (connection.State != ConnectionState.Open)
                    {
                        FormErrorShowDialog formErr = new FormErrorShowDialog("Не удалось подключиться к бд", "Ошибка");
                        formErr.ShowDialog();
                        return null;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        answer = command.ExecuteScalar().ToString();
                        return answer;
                    }
                }
            }
            catch (SqlException ex)
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла ошибка при выполнении запроса {ex.Message}", "Ошибка");
                formErr.ShowDialog();
                return null;
            }
            catch (Exception ex)
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла непредвиденная ошибка {ex.Message}", "Ошибка");
                formErr.ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Функция для любых sql запросов
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <returns></returns>
        public string SqlSimpleQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString))
                {
                    connection.Open();
                    if (connection.State != ConnectionState.Open)
                    {
                        FormErrorShowDialog formErr = new FormErrorShowDialog("Не удалось подключиться к бд", "Ошибка");
                        formErr.ShowDialog();
                        return null;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        return "1";
                    }
                }
            }
            catch (SqlException ex)
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла ошибка при выполнении запроса {ex.Message}", "Ошибка");
                formErr.ShowDialog();
                return null;
            }
            catch (Exception ex)
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла непредвиденная ошибка {ex.Message}", "Ошибка");
                formErr.ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// Функция для проверки существования записи
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <returns></returns>
        public string SqlScalarQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString))
                {
                    connection.Open();
                    if (connection.State != ConnectionState.Open)
                    {
                        FormErrorShowDialog formErr = new FormErrorShowDialog("Не удалось подключиться к бд", "Ошибка");
                        formErr.ShowDialog();
                        return null;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        var answer = command.ExecuteScalar();
                        if (answer == null)
                            return null;
                        else return answer.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла ошибка при выполнении запроса {ex.Message}", "Ошибка");
                formErr.ShowDialog();
                return null;
            }
            catch (Exception ex)
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла непредвиденная ошибка {ex.Message}", "Ошибка");
                formErr.ShowDialog();
                return null;
            }
        }
    }
}