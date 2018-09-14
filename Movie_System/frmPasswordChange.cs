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
    public partial class frmPasswordChange : Form
    {
        public frmPasswordChange()
        {
            InitializeComponent();
        }
        String connStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        
        private void frmPasswordChange_Load(object sender, EventArgs e)
        {
            string currectuser = Form1.Uid;  //string 'Currectuser' is Form1'Uid(Form1 need to 'String')
            txtUsername.Text = currectuser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select Password from MovieAccount1 where Username ='" + txtUsername.Text + "'";//Confirm password with username 
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader SDR = cmd.ExecuteReader();
            if (SDR.Read())
            {
                string OldPassword = SDR.GetString(0).Trim();
                if (OldPassword == txtOldPassword.Text)
                {
                    if (txtNewPassword.Text == "" || txtConfirmPassword.Text == "")//New and Confirm's Textboxs are null 
                    {
                        MessageBox.Show("新パスワードは空いていけません");
                        return;
                    }
                    else if (txtNewPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show("二回のパスワードは違っている、もう一度確認ください。");
                        txtNewPassword.Text = "";
                        txtConfirmPassword.Text = "";
                        return;
                    }
                    else
                    {
                        SDR.Close();//No matter Update success or fail SqlDataReader have to Close 
                        string sqlupdate = "update MovieAccount1 set Password='" + txtNewPassword.Text + "'where Username='" + txtUsername.Text + "'";
                        SqlCommand cmdup = new SqlCommand(sqlupdate, conn);// for Update Command 
                        if (cmdup.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("未知なエラーを発生しました");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("パスワード改正成功!"); 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("旧パスワードは不正確や空欄は空いていけません。");
                    //Clean
                    txtOldPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("ユーザーはいません");
                //Clean
                txtUsername.Text = "";
                txtOldPassword.Text = "";
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
                return;
            }
            conn.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();//back to main 
            this.Hide();
        }
    }
}
