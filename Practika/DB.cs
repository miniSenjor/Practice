using System;
using System.Data;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Configuration;

namespace Practika
{
    internal class DB
    {

        public DataTable SqlReturnData(string query, Guna2DataGridView dvg)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Farm"].ConnectionString))
                {
                    connection.Open();
                    if (connection.State != ConnectionState.Open)
                    {
                        FormErrorShowDialog formErr = new FormErrorShowDialog("Не удалось подключиться к бд");
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
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла ошибка при выполнении запроса {ex.Message}");
                formErr.ShowDialog();
                return null;
            }
            catch (Exception ex) 
            {
                FormErrorShowDialog formErr = new FormErrorShowDialog($"Возникла непредвиденная ошибка {ex.Message}");
                formErr.ShowDialog();
                return null;
            }
        }

        public void Registration(string query)
        {

        }
    }
}
