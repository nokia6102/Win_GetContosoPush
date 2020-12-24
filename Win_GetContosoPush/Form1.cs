using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
/*Json.NET相關的命名空間*/
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Win_TestPicClassify
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;


        public Form1()
        {
            InitializeComponent();
 
            Result_Label.Text = "";
       
        }

        private void CreateSqlConnection()
        {

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = ServerName_Text.Text;
            scsb.InitialCatalog = DBName_Text.Text;

            if (this.WinValid_Radio.Checked)
            {
                scsb.IntegratedSecurity = true;
            }
            else
            {
                scsb.IntegratedSecurity = false;
                scsb.UserID = UserName_Text.Text;
                scsb.Password = Pass_Text.Text;
            }

            this.cnn = null;
            this.cnn = new SqlConnection();
            this.cnn.ConnectionString = scsb.ConnectionString;

        }


        private void SQLValid_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (SQLValid_Radio.Checked)
            {
                UserName_Text.Enabled = true;
                Pass_Text.Enabled = true;
            }
            else
            {
                UserName_Text.Enabled = false;
                Pass_Text.Enabled = false;
            }
        }

        private void TestConnect_Btn_Click(object sender, EventArgs e)
        {
            this.CreateSqlConnection();

            try
            {
                cnn.Open();
                MessageBox.Show("連線成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("連線出問題！", "失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.cnn.Close();
            }
        }

        private void RunClassify_Btn_Click(object sender, EventArgs e)
        {
            Result_Label.Text = "";
            if (tbProductid.Text == "")
            {
                MessageBox.Show("請產輸入產品id","失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbProductid.Focus();
                return;
            }
            RunClassify_Btn.Enabled = false;
            Result_Label.Text = "計算中...";
            System.Windows.Forms.Application.DoEvents();
            Thread.Sleep(5000);

            try
            {
                this.CreateSqlConnection();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = this.cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoredProcedure_Text.Text;
                    cmd.Parameters.Add("@ProductKey", SqlDbType.NChar);
                    cmd.Parameters.Add("@OffsetNum", SqlDbType.Int);
                    cmd.Parameters.Add("@NextNum", SqlDbType.Int);
                    cmd.Parameters["@ProductKey"].Value = tbProductid.Text;
                    cmd.Parameters["@OffsetNum"].Value = 0;
                    cmd.Parameters["@NextNum"].Value = 6;

                  

                    DataTable tt = null;
                    cnn.Open();
                    SqlDataReader rr = cmd.ExecuteReader();

                    if (rr.HasRows)
                    {
                        tt = new DataTable();
                        tt.Load(rr);
                        
                    }
                    rr.Close();
                    cmd.Dispose();






                  
                    RunClassify_Btn.Enabled = true;
                    
                    if (tt != null)
                    {
                        String readJson = "";
                        readJson = tt.Rows[0][0].ToString();

                        //Newtonsoft.Json.Linq.JArray jArray = 
                        //    JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JArray>(li_showData.Text.Trim());
                        //或
                        DataTable dt = JsonConvert.DeserializeObject<DataTable>(readJson.Trim());

                        //GridView1顯示DataTable的資料
                        //GridView1.DataSource = jArray; GridView1.DataBind();
                        dataGridView1.DataSource = dt; //dataGridView1.DataBind()


                       // dataGridView1.DataSource = tt;

                        foreach (DataRow row in tt.Rows)
                        {
                            ListViewItem item = new ListViewItem(row[0].ToString());
                            for (int i = 1; i < tt.Columns.Count; i++)
                            {
                                item.SubItems.Add(row[i].ToString());
                            }
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cnn.Close();
                Result_Label.Text = "完成";
            }

        }
    }
}
