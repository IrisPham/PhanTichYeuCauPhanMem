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
        private int PhanTram(int SoCanTinh, int Tong)
        {
            if (Tong > 0)
                return (SoCanTinh * 100) / Tong;
            return 0;
        }

        private void HienBieuDo()
        {
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

        public static void GiauBieuDo(ref frmInraction f)
        {
            f.lblCLChinh.Hide();
            f.lblCLPhu.Hide();
            f.lblCNChinh.Hide();
            f.lblCNPhu.Hide();
            f.lblCDChinh.Hide();
            f.lblCDPhu.Hide();
            f.lblHLChinh.Hide();
            f.lblHNPhu.Hide();
            f.lblHLPhu.Hide();
            f.lblHNChinh.Hide();
            f.lblHDChinh.Hide();
            f.lblHDPhu.Hide();
        }

        private void ThongKe(int[] cLuanVan, int[] cNienLuan, int[] cDoAn, int[] hLuanVan, int[] hNienLuan, int[] hDoAn)
        {
            /* [0] - Hướng dẫn chính
             * [1] - Đồng hướng dẫn
             * [2] - Hướng dẫn chính trễ hạn (hLuanVan và hNienLuan)
             * [3] - Đồng hướng dẫn trễ hạn
             */

            int cluanvan, cnienluan, cdoan, hluanvan, hnienluan, hdoan;

            //Tính tổng các đề tài chưa hoàn thành và đã hoàn thành
            cluanvan = cLuanVan[0] + cLuanVan[1];
            cnienluan = cNienLuan[0] + cNienLuan[1];
            cdoan = cDoAn[0] + cDoAn[1];
            hluanvan = hLuanVan[0] + hLuanVan[1] + hLuanVan[2] + hLuanVan[3];
            hnienluan = hNienLuan[0] + hNienLuan[1] + hNienLuan[2] + hNienLuan[3];
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
            lblHLuanVanT.Text = hluanvan.ToString();
            lblHLuanVan.Text = (hLuanVan[0] + hLuanVan[1]).ToString();
            lblHLuanVan2.Text = (hLuanVan[0] + hLuanVan[2]).ToString();
            lblHLuanVan3.Text = (hLuanVan[1] + hLuanVan[3]).ToString();
            lblHTLuanVan.Text = (hLuanVan[2] + hLuanVan[3]).ToString();
            lblHNienLuanT.Text = hnienluan.ToString();
            lblHNienLuan.Text = (hNienLuan[0] + hNienLuan[1]).ToString();
            lblHNienLuan2.Text = (hNienLuan[0] + hNienLuan[2]).ToString();
            lblHNienLuan3.Text = (hNienLuan[1] + hNienLuan[3]).ToString();
            lblHTNienLuan.Text = (hNienLuan[2] + hNienLuan[3]).ToString();
            lblHDoAn.Text = hdoan.ToString();
            lblHDoAn2.Text = hDoAn[0].ToString();
            lblHDoAn3.Text = hDoAn[1].ToString();
            lblHTong.Text = (hluanvan + hnienluan + hdoan).ToString();

            //Vẽ biểu đồ cột cho đề tài luận văn chưa hoàn thành
            lblCLChinh.Height = PhanTram(cLuanVan[0], cluanvan) * 2;
            lblCLPhu.Height = 200 - lblCLChinh.Height;
            lblCLChinh.Location = new Point(lblCLPhu.Location.X, lblCLPhu.Location.Y + lblCLPhu.Height);
            if (lblCLChinh.Height < lblCLPhu.Height)
                lblCLPhu.Text = PhanTram(cLuanVan[1], cluanvan).ToString() + "%";
            else
                lblCLChinh.Text = PhanTram(cLuanVan[0], cluanvan).ToString() + "%";

            //Vẽ biểu đồ cột cho đề tài niên luận chưa hoàn thành
            lblCNChinh.Height = PhanTram(cNienLuan[0], cnienluan) * 2;
            lblCNPhu.Height = 200 - lblCNChinh.Height;
            lblCNChinh.Location = new Point(lblCNPhu.Location.X, lblCNPhu.Location.Y + lblCNPhu.Height);
            if (lblCNChinh.Height < lblCNPhu.Height)
                lblCNPhu.Text = PhanTram(cNienLuan[1], cnienluan).ToString() + "%";
            else
                lblCNChinh.Text = PhanTram(cNienLuan[0], cnienluan).ToString() + "%";

            //Vẽ biểu đồ cột cho đề tài đồ án chưa hoàn thành
            lblCDChinh.Height = PhanTram(cDoAn[0], cdoan) * 2;
            lblCDPhu.Height = 200 - lblCDChinh.Height;
            lblCDChinh.Location = new Point(lblCDPhu.Location.X, lblCDPhu.Location.Y + lblCDPhu.Height);
            if (lblCDChinh.Height < lblCDPhu.Height)
                lblCDPhu.Text = PhanTram(cDoAn[1], cdoan).ToString() + "%";
            else
                lblCDChinh.Text = PhanTram(cDoAn[0], cdoan).ToString() + "%";

            //Vẽ biểu đồ cột cho đề tài luận văn đã hoàn thành
            lblHLChinh.Height = PhanTram(hLuanVan[0], hLuanVan[0] + hLuanVan[1]) * 2;
            lblHLPhu.Height = 200 - lblHLChinh.Height;
            lblHLChinh.Location = new Point(lblHLPhu.Location.X, lblHLPhu.Location.Y + lblHLPhu.Height);
            if (lblHLChinh.Height < lblHLPhu.Height)
            {
                lblHLPhu.Text = PhanTram(hLuanVan[1], hLuanVan[0] + hLuanVan[1]).ToString() + "%";
                lblHLPhuN.Show();
                lblHLChinhN.Hide();
                lblHLPhuN.Height = lblHLPhu.Height;
                lblHLPhuN.Text = hLuanVan[1].ToString();
            }
            else {
                lblHLChinh.Text = PhanTram(hLuanVan[0], hLuanVan[0] + hLuanVan[1]).ToString() + "%";
                lblHLChinhN.Show();
                lblHLPhuN.Hide();
                lblHLChinhN.Height = lblHLChinh.Height;
                lblHLChinhN.Text = hLuanVan[0].ToString();
                lblHLChinhN.Location = new Point(lblHLPhuN.Location.X, lblHLPhu.Location.Y + lblHLPhu.Height);
            }

            lblHTLChinh.Height = PhanTram(hLuanVan[2], hLuanVan[2] + hLuanVan[3]) * 2;
            lblHTLPhu.Height = 200 - lblHTLChinh.Height;
            lblHTLChinh.Location = new Point(lblHTLPhu.Location.X, lblHTLPhu.Location.Y + lblHTLPhu.Height);
            if (lblHTLChinh.Height < lblHTLPhu.Height)
            {
                lblHTLPhu.Text = PhanTram(hLuanVan[3], hLuanVan[2] + hLuanVan[3]).ToString() + "%";
                lblHTLChinhN.Hide();
                lblHTLPhuN.Show();
                lblHTLPhuN.Height = lblHTLPhu.Height;
                lblHTLPhuN.Text = hLuanVan[3].ToString();
            }
            else {
                lblHTLChinh.Text = PhanTram(hLuanVan[2], hLuanVan[2] + hLuanVan[3]).ToString() + "%";
                lblHTLPhuN.Hide();
                lblHTLChinhN.Show();
                lblHTLChinhN.Height = lblHTLChinh.Height;
                lblHTLChinhN.Text = hLuanVan[2].ToString();
                lblHTLChinhN.Location = new Point(lblHTLPhuN.Location.X, lblHTLPhu.Location.Y + lblHTLPhu.Height);
            }

            //Vẽ biểu đồ cột cho đề tài niên luận đã hoàn thành
            lblHNChinh.Height = PhanTram(hNienLuan[0], hNienLuan[0] + hNienLuan[1]) * 2;
            lblHNPhu.Height = 200 - lblHNChinh.Height;
            lblHNChinh.Location = new Point(lblHNPhu.Location.X, lblHNPhu.Location.Y + lblHNPhu.Height);
            if (lblHNChinh.Height < lblHNPhu.Height)
            {
                lblHNPhu.Text = PhanTram(hNienLuan[1], hNienLuan[0] + hNienLuan[1]).ToString() + "%";
                lblHNPhuN.Show();
                lblHNChinhN.Hide();
                lblHNPhuN.Height = lblHNPhu.Height;
                lblHNPhuN.Text = hNienLuan[1].ToString();
            }
            else {
                lblHNChinh.Text = PhanTram(hNienLuan[0], hNienLuan[0] + hNienLuan[1]).ToString() + "%";
                lblHNChinhN.Show();
                lblHNPhuN.Hide();
                lblHNChinhN.Height = lblHNChinh.Height;
                lblHNChinhN.Text = hNienLuan[0].ToString();
                lblHNChinhN.Location = new Point(lblHNPhuN.Location.X, lblHNPhu.Location.Y + lblHNPhu.Height);
            }

            lblHTNChinh.Height = PhanTram(hNienLuan[2], hNienLuan[2] + hNienLuan[3]) * 2;
            lblHTNPhu.Height = 200 - lblHTNChinh.Height;
            lblHTNChinh.Location = new Point(lblHTNPhu.Location.X, lblHTNPhu.Location.Y + lblHTNPhu.Height);
            if (lblHTNChinh.Height < lblHTNPhu.Height)
            {
                lblHTNPhu.Text = PhanTram(hNienLuan[3], hNienLuan[2] + hNienLuan[3]).ToString() + "%";
                lblHTNPhuN.Show();
                lblHTNChinhN.Hide();
                lblHTNPhuN.Height = lblHTNPhu.Height;
                lblHTNPhuN.Text = hNienLuan[3].ToString();
            }
            else {
                lblHTNChinh.Text = PhanTram(hNienLuan[2], hNienLuan[2] + hNienLuan[3]).ToString() + "%";
                lblHTNChinhN.Show();
                lblHTNPhuN.Hide();
                lblHTNChinhN.Height = lblHTNChinh.Height;
                lblHTNChinhN.Text = hNienLuan[2].ToString();
                lblHTNChinhN.Location = new Point(lblHTNPhuN.Location.X, lblHTNPhu.Location.Y + lblHTNPhu.Height);
            }

            //Vẽ biều đồ cột cho đề tài đồ án đã hoàn thành
            lblHDChinh.Height = PhanTram(hDoAn[0], hdoan) * 2;
            lblHDPhu.Height = 200 - lblHDChinh.Height;
            lblHDChinh.Location = new Point(lblHDPhu.Location.X, lblHDPhu.Location.Y + lblHDPhu.Height);
            if (lblHDChinh.Height < lblHDPhu.Height)
                lblHDPhu.Text = PhanTram(hDoAn[1], hdoan).ToString() + "%";
            else
                lblHDChinh.Text = PhanTram(hDoAn[0], hdoan).ToString() + "%";

            //Thống kê tổng số lượng đề tài đang và đã hoàn thành
            int tongLuanVanChinh = cLuanVan[0] + hLuanVan[0] + hLuanVan[2];
            int tongLuanVanPhu = hLuanVan[1] + hLuanVan[3] + cLuanVan[1];
            int tongNienLuanChinh = cNienLuan[0] + hNienLuan[0] + hNienLuan[2];
            int tongNienLuanPhu = hNienLuan[1] + hNienLuan[3] + cNienLuan[1];
            int tongDoAnChinh = cDoAn[1] + hDoAn[1];
            int tongDoAnPhu = hDoAn[0] + cDoAn[0];
            lblTLuanVan.Text = (cluanvan + hluanvan).ToString();
            lblTLuanVan2.Text = "(" + tongLuanVanChinh.ToString() + " HD Chính, " + tongLuanVanPhu.ToString() + " Đồng HD)";
            lblTNienLuan.Text = (cnienluan + hnienluan).ToString();
            lblTNienLuan2.Text = "(" + tongNienLuanChinh.ToString() + " HD Chính, " + tongNienLuanPhu.ToString() + " Đồng HD)";
            lblTDoAn.Text = (cdoan + hdoan).ToString();
            lblTDoAn2.Text = "(" + tongDoAnChinh.ToString() + " HD Chính, " + tongDoAnPhu.ToString() + " Đồng HD)";
            lblTTong.Text = (cluanvan + hluanvan + cnienluan + hnienluan + cdoan + hdoan).ToString();
            lblTTong2.Text = "(" + (tongDoAnChinh + tongNienLuanChinh + tongLuanVanChinh).ToString() + " HD Chính, " + (tongLuanVanPhu + tongNienLuanPhu + tongDoAnPhu).ToString() + " Đồng HD)";
        }

        private bool isCheckPnMainSetting;
        public frmInraction()
        {
            InitializeComponent();
            InitializeComponent2();
            int[] cLuanVan = { 34, 66 };
            int[] cNienLuan = { 0, 0 };
            int[] cDoAn = { 32, 68 };
            int[] hLuanVan = { 0, 0, 0, 0 };
            int[] hNienLuan = { 30, 70, 40, 60 };
            int[] hDoAn = { 11, 89 };
            ThongKe(cLuanVan, cNienLuan, cDoAn, hLuanVan, hNienLuan, hDoAn);

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
    }
}
