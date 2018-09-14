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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        static string connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql="Select Username from MovieAccount1 where Username='"+txtuser.Text+"'";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql,conn);
            conn.Open();
            SqlDataReader SDR = cmd.ExecuteReader();
            if(SDR.Read())
            {
                usermag.Text = "ユーザーはもう存在します。";
                return;
            }
            else if (txtuser.Text.Trim()=="")
            {
                usermag.Text = "ユーザーは空いていけません";
            }
            else if(Password.Text.Trim()=="")
            {
                passmsg.Text = "パスワードは空いていけません";
                usermag.Text = "";

            }
            else if(PasswordConfirm.Text.Trim()=="")
            {
                passmsg1.Text = "パスワード確認は空いていけません";
                usermag.Text = "";
                passmsg.Text = "";
            }
            else if(Password.Text.Trim()!=PasswordConfirm.Text.Trim())
            {
                passmsg.Text = "パスワードとパスワード確認は違います。";
                passmsg1.Text = "もう一度確認ください";
            }
            else
            {
                usermag.Text = "";
                passmsg1.Text = "";
                passmsg.Text = "";
                conn.Close();
                string sqlInsert = "insert into MovieAccount1(Username,Password)values(@Username,@Password)";
                SqlParameter[] param =
                {
                    new SqlParameter(@"Username",txtuser.Text),
                    new SqlParameter(@"Password",Password.Text)
                };
                SqlConnection connInsert = new SqlConnection(connStr);
                SqlCommand cmdInsert = new SqlCommand(sqlInsert,connInsert);
                connInsert.Open();
                cmdInsert.Parameters.AddRange(param);
                int n = cmdInsert.ExecuteNonQuery();
                if(n==0)
                {
                    MessageBox.Show("登録失敗しました");
                    return;
                }
                else
                {
                    MessageBox.Show("登録成功しました");
                    return;
                }
                connInsert.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
