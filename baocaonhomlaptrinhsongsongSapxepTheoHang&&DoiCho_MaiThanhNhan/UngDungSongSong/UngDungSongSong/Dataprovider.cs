using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungSongSong
{
 public   class Dataprovider
    {

        private DataTable dt;
        private SqlDataAdapter da;
        private static Dataprovider instance;

        public static Dataprovider Instance
        {
            get { if (instance == null) instance = new Dataprovider(); return Dataprovider.instance; }
            private set { Dataprovider.instance = value; }
        }

        public SqlConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8SENJ8A\\SQLEXPRESS;Initial Catalog = QLUngDung; User ID = sa; password=sa123456");

        public DataTable laydulieutubang(string sql)
        {

            dt = new DataTable();
            da = new SqlDataAdapter(sql, Con);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public bool thucthicaulenhsql(string sql)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(sql, Con);
            int x = cmd.ExecuteNonQuery();
            Con.Close();
            if (x > 0)
            {
                return true;
            }
            return false;
        }


        public string laydulieusql(string sql)
        {
            string x = "";


            if (laydulieutubang(sql).Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return x;
            }



        }
        public string laydulieufloatsql(string sql)
        {
            string x = "";


            if (laydulieutubang(sql).Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
                return x;
        }
        public string GetLastID(string nameTable, string nameFiled)
        {
            Con.Open();
            string sql = "SELECT TOP (1) " + nameFiled + " FROM " + nameTable + " ORDER BY " + nameFiled + " DESC";
            laydulieutubang(sql);
            Con.Close();
            // thực hiện câu truy vấn trên
            return dt.Rows[0][nameFiled].ToString();
        }

    }

}


