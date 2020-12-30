using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;
using System.Data.Common;
using MetroFramework.Controls;
using BLL;
using DTO.DocGia;
using DTO.Sach;
using DTO.TheLoai;
using DTO.NhanVien;
using DTO.MuonTra;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using QuanLyThuVien.Common;

namespace QuanLyThuVien.Form_ThongKe
{
   
    public partial class fThongKe : UserControl
    {
        HttpClient cl = new HttpClient();
        TheLoaiAccess tla = new TheLoaiAccess();
        ThongKeBLL thongKeBLL = new ThongKeBLL();
        public fThongKe()
        {
            InitializeComponent();
            DauSachMuonNhieu();
            LoadListTheLoai();
            SachConLai();
            TheLoaiYeuThich();
        }
        public async void LoadListTheLoai()
        {
            string url = GlobalVariable.url + "api/TheLoai";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<TheLoai>>(json);

            

            foreach (var item in list)
            {
                LinkLabel linkLabel = new LinkLabel() { Text = item.TenTheLoai.ToString() };
                linkLabel.Click += linkLabel_Click;
                flowLayout3.Controls.Add(linkLabel);
                flowLayout3.FlowDirection = FlowDirection.TopDown;
            }
        }
        private async void linkLabel_Click(object sender, EventArgs e)
        {
            LinkLabel x = (LinkLabel)sender;
            String tenTheLoai = x.Text;

            string url = GlobalVariable.url + "api/PhanLoai?name="+tenTheLoai;
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<SachTheoTheLoai>>(json);
          
            //var list = new DauSachAccess().DanhSachDauSachTheoTheLoai(tenTheLoai);
            lvSachTheoTheLoai.Items.Clear();
            int i = 1;
            foreach(var item in list)
            {
                ListViewItem lvi = new ListViewItem(i+"");
                lvi.SubItems.Add(item.MaSach+"");
               
                lvSachTheoTheLoai.Items.Add(lvi);
                i++;
            }
        }

        public void DauSachMuonNhieu()
        {
            var list = thongKeBLL.DauSachMuonNhieu().ToList();
            lvDauSachMuonNhieu.Items.Clear();
            int i = 1;
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(i + "");
                lvi.SubItems.Add(item.TenDauSach);
                lvi.SubItems.Add(item.Tap + "");
                lvi.SubItems.Add(item.SoLuotMuon+"");
                lvDauSachMuonNhieu.Items.Add(lvi);
                i++;
            }
        }
        public void SachConLai()
        {
            var list = thongKeBLL.SachConLai().ToList();
            lvSachConLai.Items.Clear();
            int i = 1;
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(i + "");
                lvi.SubItems.Add(item.TenDauSach);
                lvi.SubItems.Add(item.Tap + "a");
                lvi.SubItems.Add(item.SoLuotMuon + "");
                lvSachConLai.Items.Add(lvi);
                i++;
            }
        }
        public async void TheLoaiYeuThich()
        {
            string url = GlobalVariable.url + "api/TheLoai";
            string json = await new GlobalVariable().GetApiAsync(url);
            var list = JsonConvert.DeserializeObject<List<TheLoai>>(json);
           // var list = new ThongKeAccess().TheLoaiYeuThich().ToList();
            lvTheLoai.Items.Clear();
            int i = 1;
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem(i + "");
                lvi.SubItems.Add(item.TenTheLoai);
                lvi.SubItems.Add(item.MaTheLoai+ "a");
                lvTheLoai.Items.Add(lvi);
                i++;
            }
        }
    }
}