using Microsoft.Data.SqlClient;
using PRN_ASG.Setting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PRN_ASG.DAL
{
    internal class DAO
    {
        private string connectionString;

        public DAO()
        {
            getConnectionString();
            connect();
        }

        private void getConnectionString()
        {
            connectionString = new ReadSetting().readConnection();
        }

        private void connect()
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(connectionString);
                if (dbConnection.State == ConnectionState.Open)
                {
                    dbConnection.Close();
                }
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect failed:" + ex.Message);
            }
        }

        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection);

                    if (parameters != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(parameters);
                    }

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query execution error:" + ex.Message);
                return null; // Handle the error as needed in your application
            }
        }

        public bool ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(connectionString))
                {
                    dbConnection.Open();
                    using (var command = new SqlCommand(query, dbConnection))
                    {
                        command.CommandType = CommandType.Text;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert/Update/Delete error:" + ex.Message);
                return false;
            }
        }
    }
}
