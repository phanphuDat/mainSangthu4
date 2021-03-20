using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace OOP_HuongDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Qlsv db = new Qlsv();
            // Sv sv1 = new Sv{ MSSV = 1, tenSv="Phan Phu Dat" };
            // Sv sv2 = new Sv{ MSSV = 2, tenSv="Phan Phu Quoc" };
            // Sv sv3 = new Sv{ MSSV = 3, tenSv="Phan Phu Oanh" };
            // db.Add(sv2);
            // db.Add(sv1);
            // Console.WriteLine(db.ToString());

            String cnnstr = "Data Source = DESKTOP-1GG0LVP ; Initial Catalog = QLSV; " + "Integrated Security = true";
            SqlConnection cnn = new SqlConnection(cnnstr);
            cnn.Open();
            Console.WriteLine(cnn.State.ToString());
            cnn.Close();
            Console.WriteLine(cnn.State.ToString());
            //ExecuteScalar() -> select count * ->dem va tra so dong cua bang du lieu
            string query = "select count (*) from SV";
            SqlCommand cmd = new SqlCommand(query,cnn);
            cnn.Open();
            int n = (int)cmd.ExecuteScalar();
            cnn.Close();
            Console.WriteLine(n.ToString());

            //ExecuteNonQuery() -> insert, delete, update

            string querydelete = "delete from SV where MSSV='MS01'";
            string queryinsert = "insert into SV values ('MS04', 'Phan Phu Dat1', 'nam', '2000/02/20', 1)";
            SqlCommand cmd1 = new SqlCommand(queryinsert,cnn);
            cnn.Open();
            // int n1 = (int)cmd1.ExecuteNonQuery();
            // Console.WriteLine(n1.ToString());

            //ExecuteReader() -> select, select ... from

             string querySelect = "select * from SV";
            SqlCommand cmd2 = new SqlCommand(querySelect,cnn);
            SqlDataReader r = cmd2.ExecuteReader();
                while(r.Read()) {
                    string MSSV = r["MSSV"].ToString();
                    string NameSV = r["NameSV"].ToString();
                    Console.WriteLine("MSSV = {0} , NameSV = {1}", MSSV, NameSV);
                }
            
            SqlDataAdapter da = new SqlDataAdapter(querySelect, cnn);
            cnn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            foreach(DataRow i in dt.Rows)
            {
                string MSSV = r["MSSV"].ToString();
                string NameSV = r["NameSV"].ToString();
                Console.WriteLine("MSSV + {0} , NameSV + {1}", MSSV, NameSV);
            }
        }
 
    }
}
