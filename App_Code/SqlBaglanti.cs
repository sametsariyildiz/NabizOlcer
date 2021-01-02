using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace NabizOlcer.App_Code
{
    class SqlBaglanti
    {
        public SqlConnection baglan()
        {
            string connectionString = @"Data Source=185.136.84.130\MSSQLSERVER2017; User Id=nabiz; Password=yukseklisans1.; Database=YELLOWSTAR; ";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            return conn;
        }

        public DataTable data(string komut)
        {
            SqlConnection conn = this.baglan();
            SqlCommand cmd = new SqlCommand(komut, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                sda.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
        

            return dt;
        }


    }
}
