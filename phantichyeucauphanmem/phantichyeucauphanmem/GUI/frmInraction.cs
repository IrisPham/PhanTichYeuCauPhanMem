using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phantichyeucauphanmem
{
    public partial class frmInraction : Form
    {
        private bool isCheckPnMainSetting;
        public frmInraction()
        {
            InitializeComponent();
            InitializeComponent2();
        }
        private void InitializeComponent2()
        {
            //khởi tạo giao diện 
            //Ẩn tất cả các panel
            pnThongKe.Hide();
            pnLuanVan.Hide();
            pnNienLuan.Hide();
            pnDeTai.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Phương thức dùng để xem chi tiết trong pnMainSetting
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (isCheckPnMainSetting)
            {
                isCheckPnMainSetting = false;
                
                pnMainSetting.Size = new Size(60, 661);
                //pnThongTinNguoiDung.Location = new Point(62, 1);
                //pnThongKe.Location = new Point(62, 1);
                //pnLuanVan.Location = new Point(62, 1);
                //pnNienLuan.Location = new Point(62, 1);
                //pnDeTai.Location = new Point(62, 1);

            }
            else
            {
                isCheckPnMainSetting = true;  
                pnMainSetting.Size = new Size(148, 661);
                //pnThongTinNguoiDung.Location = new Point(154, 1);
                //pnThongKe.Location = new Point(154, 1);
                //pnLuanVan.Location = new Point(154, 1);
                //pnNienLuan.Location = new Point(154, 1);
                //pnDeTai.Location = new Point(154, 1);
            }

        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            pnThongKe.Show();
            pnLuanVan.Hide();
            pnNienLuan.Hide();
            pnDeTai.Hide();
        }

        private void btnDissertation_Click(object sender, EventArgs e)
        {
            pnThongKe.Hide();
            pnLuanVan.Show();
            pnNienLuan.Hide();
            pnDeTai.Hide();
        }

        private void btnNienLuan_Click(object sender, EventArgs e){
            pnThongKe.Hide();
            pnLuanVan.Hide();
            pnNienLuan.Show();
            pnDeTai.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pnThongKe.Hide();
            pnLuanVan.Hide();
            pnNienLuan.Hide();
            pnDeTai.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConnectionSQL.SQL.connect();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pnMainSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
