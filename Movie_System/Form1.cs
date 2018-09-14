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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
 
        }
        public static string Uid;
        public static DateTime Time;
        public static string Situation;

        string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //sql code
                string sql = "select Password from MovieAccount1 where Username='" + ID.Text + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader SDR = cmd.ExecuteReader())
                    {
                        if (SDR.Read())
                        {
                            string pw = SDR.GetString(0).Trim();
                            if (pw == PW.Text)
                            {
                                Uid = ID.Text;
                                Time = DateTime.Now;
                                Situation = "ログイン中";
                                MessageBox.Show("ログイン成功しました、ただいま主ページを導入します。");
                               frmMain main = new frmMain();
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("ログイン失敗しました、使用者データを確認ください。");
                                PW.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("ログイン失敗しました、使用者データを確認ください。");
                            ID.Text = "";
                        }
                    }
                }

            }

        
        }
    }
}
