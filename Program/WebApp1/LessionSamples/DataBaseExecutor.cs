using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LessionSamples
{
    class DataBaseExecutor
    {
        public static void ReadTestTable1()
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            string queryString =
                $@" SELECT * FROM TestTable1
                    WHERE NumberCol = @NumberCol 
                    ORDER BY ID DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@NumberCol", "3");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            "\t{0}\t{1}\t{2}",
                            reader["ID"],
                            reader["Birthday"],
                            reader["Name"]
                        );
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //finally
                //{
                //    connection.Close();
                //}
            }
        }

        public static DataTable ReadTestTable1DT()
        {
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";
            string queryString =
                $@" SELECT * FROM TestTable1
                    WHERE NumberCol = @NumberCol 
                    ORDER BY ID DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@NumberCol", "3");

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();

                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    Console.WriteLine("\t{0}\t{1}", 
                    //        dr["ID"],
                    //        dr["Name"]
                    //    );
                    //}

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public static DataTable ReadTestTable1OneRow(string id)
        {
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";
            string queryString =
                $@" SELECT * FROM TestTable1
                    WHERE ID = @id
                    ORDER BY ID DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public static void UpdateTestTable1(string id, string name, string birthday, string numbercol)
        {
            //string connectionString =
            //    "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            //string queryString =
            //    $@" INSERT INTO TestTable1
            //            (ID, Name, Birthday, NumberCol)
            //        VALUES
            //            (@ID, @Name, @Birthday, @NumberCol)";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    command.Parameters.AddWithValue("@ID", id);
            //    command.Parameters.AddWithValue("@Name", name);
            //    command.Parameters.AddWithValue("@Birthday", birthday);
            //    command.Parameters.AddWithValue("@NumberCol", numbercol);

            //    try
            //    {
            //        connection.Open();
            //        int totalChangeRows = command.ExecuteNonQuery();
            //        Console.WriteLine("Total change " + totalChangeRows + "Rows.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }


        public static void InsertTestTable1(string id, string name, string birthday, string numbercol)
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            string queryString =
                $@" INSERT INTO TestTable1
                        (ID, Name, Birthday, NumberCol)
                    VALUES
                        (@ID, @Name, @Birthday, @NumberCol)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Birthday", birthday);
                command.Parameters.AddWithValue("@NumberCol", numbercol);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    Console.WriteLine("Total change " + totalChangeRows + "Rows.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void DeleteTestTable1(string id)
        {
            string connectionString =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            string queryString =
                $@" DELETE FROM TestTable1 WHERE ID = @ID;";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();

                    HttpContext.Current.Response.Write("Total change " + totalChangeRows + "Rows.");
                }
                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                }
            }
        }

        public static DataTable BuildDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Birthday", typeof(DateTime));
            dt.Columns["Birthday"].AllowDBNull = true;

            DateTime baseDate = new DateTime(2021, 1, 1);
            for (var i = 0; i < 50; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i;
                dr["Name"] = "UserName " + i;
                dr["Birthday"] = baseDate.AddDays(i);
                dt.Rows.Add(dr);
            }

            return dt;
        }

        public static DataTable AdapterToDt()
        {
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";
            string queryString =
                $@" SELECT * FROM TestTable1
                    WHERE NumberCol = @NumberCol 
                    ORDER BY ID DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adp = new SqlDataAdapter(queryString, connectionString);
                adp.SelectCommand.Parameters.AddWithValue("@NumberCol", "3");

                try
                {
                    DataSet dst = new DataSet();
                    adp.Fill(dst);

                    if (dst.Tables.Count == 0)
                        return null;

                    return dst.Tables[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}