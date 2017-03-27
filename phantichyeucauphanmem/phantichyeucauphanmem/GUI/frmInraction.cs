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
    public partial class Form1 : Form
    {
        private bool isCheckPnMainSetting;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent2();
        }
        private void InitializeComponent2()
        {
            //khởi tạo giao diện 
            //Ẩn tất cả các panel
            pnThongTinNguoiDung.Hide();
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
                pnMainSetting.Size = new Size(60, 482);
                pnThongTinNguoiDung.Location = new Point(62, 1);
                pnThongKe.Location = new Point(62, 1);
                pnLuanVan.Location = new Point(62, 1);
                pnNienLuan.Location = new Point(62, 1);
                pnDeTai.Location = new Point(62, 1);
            }
            else
            {
                isCheckPnMainSetting = true;  
                pnMainSetting.Size = new Size(148, 482);
                pnThongTinNguoiDung.Location = new Point(154, 1);
                pnThongKe.Location = new Point(154, 1);
                pnLuanVan.Location = new Point(154, 1);
                pnNienLuan.Location = new Point(154, 1);
                pnDeTai.Location = new Point(154, 1);
            }

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnThongTinNguoiDung.Show();
            pnThongKe.Hide();
            pnLuanVan.Hide();
            pnNienLuan.Hide();
            pnDeTai.Hide();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            pnThongTinNguoiDung.Hide();
            pnThongKe.Show();
            pnLuanVan.Hide();
            pnNienLuan.Hide();
            pnDeTai.Hide();
        }

        private void btnDissertation_Click(object sender, EventArgs e)
        {
            pnThongTinNguoiDung.Hide();
            pnThongKe.Hide();
            pnLuanVan.Show();
            pnNienLuan.Hide();
            pnDeTai.Hide();
        }

        private void btnNienLuan_Click(object sender, EventArgs e){
            pnThongTinNguoiDung.Hide();
            pnThongKe.Hide();
            pnLuanVan.Hide();
            pnNienLuan.Show();
            pnDeTai.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pnThongTinNguoiDung.Hide();
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

        }
}
