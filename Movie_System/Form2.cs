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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        String ConnStr = ConfigurationManager.ConnectionStrings["str"].ConnectionString;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'moiveDataSet.Record' 資料表。您可以視需要進行移動或移除。
           
            // TODO: 這行程式碼會將資料載入 'moiveDataSet.Record' 資料表。您可以視需要進行移動或移除。


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string sql = "select * from Record ";
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {

                string sql = "insert into Record(Movie_Name,Movie_Director,Data_Released) values (@Movie_Name,@Movie_Director,@Date_Released)";
                if (txtMovie.Text.Trim() == "" || txtDirector.Text.Trim() == "" || txtDate.Text.Trim() == "")
                {
                    MessageBox.Show("データは空いていけません、全部は填まってください!");
                    return;
                }
                SqlParameter[] param =
                {
                new SqlParameter("@Movie_Name",txtMovie.Text),
                new SqlParameter("@Movie_Director",txtDirector.Text),
                new SqlParameter("@Date_Released",Convert.ToDateTime(txtDate.Text))
            };
                SqlConnection conn = new SqlConnection(ConnStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddRange(param);
                n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("増加失敗しました");
                    return;
                }
                else if (n > 0)
                {
                    MessageBox.Show("増加成功しました");

                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("増加失敗しました、データベース環境を確認ください");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from Record Where 1=1";
                if (dataGridView1.CurrentRow.Selected)
                {
                    sql = sql + "and ID=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
                int n = 0;
                SqlConnection conn = new SqlConnection(ConnStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("このIDはありません、もう一度確認ください");
                    return;
                }
                else if (n > 1)
                {
                    MessageBox.Show("削除完成しました!");
                }
            }
            catch
            {
                MessageBox.Show("削除失敗しました、データベース環境を確認ください");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMovie.Text.Trim()==""||txtDirector.Text.Trim()==""||txtDate.Text.Trim()=="")
            {
                MessageBox.Show("データは空いていけません、全部は填まってください!");
                return;
            }
            string sqlUpdate = "update Record set Movie_Name='" + txtMovie.Text + "',Movie_Director='" + txtDirector.Text + "',Data_Released='" + txtDate.Text + "'where ID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            if(n==0)
            {
                MessageBox.Show("更新失敗しました");
                return;
            }
            else if(n>0)
            {
                MessageBox.Show("更新成功しました、おめでとう");
            }
            conn.Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
