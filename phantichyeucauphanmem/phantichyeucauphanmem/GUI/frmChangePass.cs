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
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        frmLogin Lg = new frmLogin();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Vui lòng nhập mật khẩu cũ của bạn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtmkm.Text == "") {
                    MessageBox.Show("Bạn chưa nhập mật khẩu cần thay đổi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                   
                    String sql1 = "Select COUNT(*) from Account where UserName='" + txttk.Text + "' and Password='" + txtmk.Text + "'";
                    ConnectionSQL.SQL.comnd = new SqlCommand(sql1, ConnectionSQL.SQL.sql);
                    int x = (int)ConnectionSQL.SQL.comnd.ExecuteScalar();
                    if (x == 1)
                    {
                        //try
                        //{
                            String sql2 = "UPDATE Account SET Password ="+txtmkm.Text+" WHERE Password = "+txtmk.Text+" AND UserName = '"+txttk.Text+"'";
                            ConnectionSQL.SQL.comnd = ConnectionSQL.SQL.sql.CreateCommand();
                            ConnectionSQL.SQL.comnd.CommandText = sql2;
                            ConnectionSQL.SQL.comnd.ExecuteNonQuery();
                            MessageBox.Show("Thay đổi thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //catch (Exception ex) {
                           // MessageBox.Show(ex.Message);
                       // }
                   // }
                    

                    else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            txttk.Clear();
            txtmk.Clear();
            txtmkm.Clear();
        }
    }
}
