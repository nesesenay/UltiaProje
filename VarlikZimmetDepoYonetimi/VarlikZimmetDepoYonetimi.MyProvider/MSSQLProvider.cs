using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetimi.MyProvider
{
    public class MSSQLProvider
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;

        public MSSQLProvider(string YapilmakIstenenSorgu, string Adres= "server=NESE\\SQLEXPRESS;Database=Ultia;Integrated Security=True") 
        {
            conn = new SqlConnection(Adres);
            cmd = new SqlCommand();
            cmd.CommandText = YapilmakIstenenSorgu;
            cmd.Connection = conn;
        }

        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public int ExcutNon()
        {
            int result = 0;

            try
            {

                Open();
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                result = 0;
            }
            finally
            {
                Close();
            }

            return result;
        }

        public object ExecutScalar()
        {
            object result = null;

            try
            {
                Open();
                result = cmd.ExecuteScalar();
            }
            catch (Exception)
            {


            }
            finally
            {
                Close();
            }

            return result;
        }

        public SqlDataReader ExcuteredaerOlustur()
        {
            return cmd.ExecuteReader();
        }

        public void ParametreEkle(SqlParameter[] sqlParameters)
        {
            cmd.Parameters.AddRange(sqlParameters);
        }

    }
}
