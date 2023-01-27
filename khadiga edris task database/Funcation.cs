using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khadiga_edris_task_database
{
    internal class Funcation
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConSter;
        public Funcation()
        {
            ConSter =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\EmpD.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConSter);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;


        }
        public DataTable GetData(string Query)
        {

        dt = new DataTable();
        sda = new SqlDataAdapter(Query, ConSter);
        sda.Fill(dt);
        return dt ;
        }
        public int SetData(string Query)
        {
        int cnt = 0;
        if(Con.State == ConnectionState.Closed)
        {
            Con.Open();
        }
        Cmd.CommandText = Query;
        cnt = Cmd.ExecuteNonQuery();
        return cnt;
        }
        

    }

}
