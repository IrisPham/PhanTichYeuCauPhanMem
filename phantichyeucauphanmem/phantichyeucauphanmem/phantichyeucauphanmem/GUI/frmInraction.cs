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

        private int PhanTram(int SoCanTinh, int Tong) {
            return (SoCanTinh * 100) / Tong;
        }

        private void HienBieuDo() {
            lblCLChinh.Show();
            lblCLPhu.Show();
            lblCNChinh.Show();
            lblCNPhu.Show();
            lblCDChinh.Show();
            lblCDPhu.Show();
            lblHLChinh.Show();
            lblHNPhu.Show();
            lblHLPhu.Show();
            lblHNChinh.Show();
            lblHDChinh.Show();
            lblHDPhu.Show();
        }

        private void GiauBieuDo() {
            lblCLChinh.Hide();
            lblCLPhu.Hide();
            lblCNChinh.Hide();
            lblCNPhu.Hide();
            lblCDChinh.Hide();
            lblCDPhu.Hide();
            lblHLChinh.Hide();
            lblHNPhu.Hide();
            lblHLPhu.Hide();
            lblHNChinh.Hide();
            lblHDChinh.Hide();
            lblHDPhu.Hide();
        }

        private void ThongKe(int []cLuanVan, int []cNienLuan, int []cDoAn, int []hLuanVan, int []hNienLuan, int []hDoAn) {

            int cluanvan, cnienluan, cdoan, hluanvan, hnienluan, hdoan;

            //Tính tổng các đề tài chưa hoàn thành và đã hoàn thành
            cluanvan = cLuanVan[0] + cLuanVan[1];
            cnienluan = cNienLuan[0] + cNienLuan[1];
            cdoan = cDoAn[0] + cDoAn[1];
            hluanvan = hLuanVan[0] + hLuanVan[1];
            hnienluan = hNienLuan[0] + hNienLuan[1];
            hdoan = hDoAn[0] + hDoAn[1];

            //Đặt số lượng đề tài chưa hoàn thành
            lblCLuanVan.Text = cluanvan.ToString();
            lblCLuanVan2.Text = cLuanVan[0].ToString();
            lblCLuanVan3.Text = cLuanVan[1].ToString();
            lblCNienLuan.Text = cnienluan.ToString();
            lblCNienLuan2.Text = cNienLuan[0].ToString();
            lblCNienLuan3.Text = cNienLuan[1].ToString();
            lblCDoAn.Text = cdoan.ToString();
            lblCDoAn2.Text = cDoAn[0].ToString();
            lblCDoAn3.Text = cDoAn[1].ToString();
            lblCTong.Text = (cluanvan + cnienluan + cdoan).ToString();

            //Đặt số lượng đề tài đã hoàn thành
            lblHLuanVan.Text = hluanvan.ToString();
            lblHLuanVan2.Text = hLuanVan[0].ToString();
            lblHLuanVan3.Text = hLuanVan[1].ToString();
            lblHNienLuan.Text = hnienluan.ToString();
            lblHNienLuan2.Text = hNienLuan[0].ToString();
            lblHNienLuan3.Text = hNienLuan[1].ToString();
            lblHDoAn.Text = hdoan.ToString();
            lblHDoAn2.Text = hDoAn[0].ToString();
            lblHDoAn3.Text = hDoAn[1].ToString();
            lblHTong.Text = (hluanvan + hnienluan + hdoan).ToString();

            //Vẽ biểu đồ cột cho đề tài luận văn chưa hoàn thành
            lblCLChinh.Height = PhanTram(cLuanVan[1],cluanvan) * 2;
            lblCLPhu.Height = 200 - lblCLChinh.Height;
            lblCLChinh.Location = new Point(lblCLPhu.Location.X, lblCLPhu.Location.Y + lblCLPhu.Height);
            if (lblCLChinh.Height < lblCLPhu.Height)
                lblCLPhu.Text = PhanTram(cLuanVan[0], cluanvan).ToString() + "%";
            else
                lblCLChinh.Text = PhanTram(cLuanVan[1], cluanvan).ToString() + "%";

            //Vẽ biểu đồ cột cho đề tài niên luận chưa hoàn thành
            lblCNChinh.Height = PhanTram(cNienLuan[1], cnienluan) * 2;
            lblCNPhu.Height = 200 - lblCNChinh.Height;
            lblCNChinh.Location = new Point(lblCNPhu.Location.X, lblCNPhu.Location.Y + lblCNPhu.Height);
            if (lblCNChinh.Height < lblCNPhu.Height)
                lblCNPhu.Text = PhanTram(cNienLuan[0], cnienluan).ToString() + "%";
            else
                lblCNChinh.Text = PhanTram(cNienLuan[1], cnienluan).ToString() + "%";

            //Vẽ biểu đồ cột cho đề tài đồ án chưa hoàn thành
            lblCDChinh.Height = PhanTram(cDoAn[1], cdoan) * 2;
            lblCDPhu.Height = 200 - lblCDChinh.Height;
            lblCDChinh.Location = new Point(lblCDPhu.Location.X, lblCDPhu.Location.Y + lblCDPhu.Height);
            if (lblCDChinh.Height < lblCDPhu.Height)
                lblCDPhu.Text = PhanTram(cDoAn[0], cdoan).ToString() + "%";
            else
                lblCDChinh.Text = PhanTram(cDoAn[1], cdoan).ToString() + "%";

            //Vẽ biểu đồ cột cho đề tài luận văn đã hoàn thành
            lblHLChinh.Height = PhanTram(hLuanVan[1], hluanvan) * 2;
            lblHLPhu.Height = 200 - lblHLChinh.Height;
            lblHLChinh.Location = new Point(lblHLPhu.Location.X, lblHLPhu.Location.Y + lblHLPhu.Height);
            if (lblHLChinh.Height < lblHLPhu.Height)
                lblHLPhu.Text = PhanTram(hLuanVan[0], hluanvan).ToString() + "%";
            else
                lblHLChinh.Text = PhanTram(hLuanVan[1], hluanvan).ToString() + "%";

            //Vẽ biểu đồ cột cho đề tài niên luận đã hoàn thành
            lblHNChinh.Height = PhanTram(hNienLuan[1], hnienluan) * 2;
            lblHNPhu.Height = 200 - lblHNChinh.Height;
            lblHNChinh.Location = new Point(lblHNPhu.Location.X, lblHNPhu.Location.Y + lblHNPhu.Height);
            if (lblHNChinh.Height < lblHNPhu.Height)
                lblHNPhu.Text = PhanTram(hNienLuan[0], hnienluan).ToString() + "%";
            else
                lblHNChinh.Text = PhanTram(hNienLuan[1], hnienluan).ToString() + "%";

            //Vẽ biều đồ cột cho đề tài đồ án đã hoàn thành
            lblHDChinh.Height = PhanTram(hDoAn[1], hdoan) * 2;
            lblHDPhu.Height = 200 - lblHDChinh.Height;
            lblHDChinh.Location = new Point(lblHDPhu.Location.X, lblHDPhu.Location.Y + lblHDPhu.Height);
            if (lblHDChinh.Height < lblHDPhu.Height)
                lblHDPhu.Text = PhanTram(hDoAn[0], hdoan).ToString() + "%";
            else
                lblHDChinh.Text = PhanTram(hDoAn[1], hdoan).ToString() + "%";

            //Thống kê tổng số lượng đề tài đang và đã hoàn thành
            int tongLuanVanChinh = cLuanVan[1] + hLuanVan[1];
            int tongLuanVanPhu = hLuanVan[0] + cLuanVan[0];
            int tongNienLuanChinh = cNienLuan[1] + hNienLuan[1];
            int tongNienLuanPhu = hNienLuan[0] + cNienLuan[0];
            int tongDoAnChinh = cDoAn[1] + hDoAn[1];
            int tongDoAnPhu = hDoAn[0] + cDoAn[0];
            lblTLuanVan.Text = (cluanvan + hluanvan).ToString();
            lblTLuanVan2.Text = "(" + tongLuanVanChinh.ToString() + " HD Chính, " + tongLuanVanPhu.ToString() + " HD Phụ)";
            lblTNienLuan.Text = (cnienluan + hnienluan).ToString();
            lblTNienLuan2.Text = "(" + tongNienLuanChinh.ToString() + " HD Chính, " + tongNienLuanPhu.ToString() + " HD Phụ)";
            lblTDoAn.Text = (cdoan + hdoan).ToString();
            lblTDoAn2.Text = "(" + tongDoAnChinh.ToString() + " HD Chính, " + tongDoAnPhu.ToString() + " HD Phụ)";
            lblTTong.Text = (cluanvan + hluanvan + cnienluan + hnienluan + cdoan + hdoan).ToString();
            lblTTong2.Text = "(" + (tongDoAnChinh + tongNienLuanChinh + tongLuanVanChinh).ToString() + " HD Chính, " + (tongLuanVanPhu + tongNienLuanPhu + tongDoAnPhu).ToString() + " HD Phụ)";
        }

        private bool isCheckPnMainSetting;
        public frmInraction()
        {
            InitializeComponent();
            InitializeComponent2();
            int[] cLuanVan = { 20, 80 };
            int[] cNienLuan = { 30, 70 };
            int[] cDoAn = { 50, 50 };
            int[] hLuanVan = { 10, 90 };
            int[] hNienLuan = { 60, 40 };
            int[] hDoAn = { 0, 100 };
            
            ThongKe(cLuanVan, cNienLuan, cDoAn, hLuanVan, hNienLuan, hDoAn);
        }
        private void InitializeComponent2()
        {
            //khởi tạo giao diện 
            //Ẩn tất cả các panel
            pnThongTinNguoiDung.Hide();
            pnThongKe.Hide();
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

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnThongTinNguoiDung.Show();
            pnThongKe.Hide();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            pnThongTinNguoiDung.Hide();
            pnThongKe.Show();
        }

        private void btnDissertation_Click(object sender, EventArgs e)
        {
            pnThongTinNguoiDung.Hide();
            pnThongKe.Hide();
        }

        private void btnNienLuan_Click(object sender, EventArgs e){
            pnThongTinNguoiDung.Hide();
            pnThongKe.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pnThongTinNguoiDung.Hide();
            pnThongKe.Hide();
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
