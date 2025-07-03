using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MediTrack_PMS
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = TECH-SAVY\\SQLEXPRESS; database = pharmacy; integrated security = True";
            return con;
        }

        // Existing getData method (1 argument)
        public DataSet getData(String query)
        {
            using (SqlConnection con = getConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            con.Open();
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        // New overload for getData with parameters (2 arguments)
        public DataSet getData(String query, Dictionary<string, object> parameters)
        {
            using (SqlConnection con = getConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the command
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                            }
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            con.Open();
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        // Existing setData method (2 arguments)
        public void setData(String query, String msg)
        {
            using (SqlConnection con = getConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // New overload for setData with parameters (3 arguments)
        public void setData(String query, Dictionary<string, object> parameters, String msg)
        {
            using (SqlConnection con = getConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to the command
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                            }
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}