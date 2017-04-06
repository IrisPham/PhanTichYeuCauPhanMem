using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace phantichyeucauphanmem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
           InitializeComponent();
        }
        frmInraction frmIn = new frmInraction();
        
        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionSQL.SQL.connect();
            if (txttk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtmk.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    String sql1 = "Select COUNT(*) from Account where UserName='"+txttk.Text+"' and Password='"+txtmk.Text+"'";
                    ConnectionSQL.SQL.comnd = new SqlCommand(sql1, ConnectionSQL.SQL.sql);
                    int x = (int)ConnectionSQL.SQL.comnd.ExecuteScalar();
                    if (x == 1)
                    {

                        this.Hide();
                        frmIn.ShowDialog();
                        this.Dispose();
                    }
                    else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               

            }


            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmChangePass frmChange = new frmChangePass();
            frmChange.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtmk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
