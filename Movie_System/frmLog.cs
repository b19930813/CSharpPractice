using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_System
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }
        static string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new Movie_System.frmMain(); //back main
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetExitTime(); 
            Addlog(); //Insert to database which username,Situation and Time
            Application.Exit(); //Close Program

        }

        private void GetExitTime()
        {
            Form1.Time = DateTime.Now; 
            Form1.Situation = "退出";
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            Addlog();
            ShowMSG();
        }

        private void ShowMSG()
        {
            string showsql = "select ID,Username,Situation,Time from Log";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(showsql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Addlog()
        {
            string sql = "insert into Log(Username,Situation,Time) values (@Username,@Situation,@Time)";
            if(Form1.Uid==""||Form1.Situation==""||Form1.Time.ToString()=="")
            {
                MessageBox.Show("データは空いていけません!");
                return;
            }
            SqlParameter[] param = { 
                new SqlParameter("@Username",Form1.Uid),
                new SqlParameter("@Situation",Form1.Situation),
                new SqlParameter("@Time",Form1.Time)
            };
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddRange(param);
           int n = cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
