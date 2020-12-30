using BLL;
using DTO.DocGia;
using QuanLyThuVien.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Form_DocGia
{
    public partial class ThemDocGIa : Form
    {
        private DocGiaBLL docGiaBLL;
        public ThemDocGIa()
        {
            InitializeComponent();
            docGiaBLL = new DocGiaBLL();
        }
        

        private async void saveDocGiaDB(object sender, EventArgs e)
        {
            DocGia docGia = new DocGia();
            if (txtBoxMaDocGia.Text.Length == 0)
            {
                MessageBox.Show("Mã độc giả không được trống");
                return;
                
            }
            if (txtBoxThemTenDocGia.Text.Length == 0)
            {
                MessageBox.Show("Mã độc giả không được trống");
                return;
            }
            
            docGia.maDocGia = Int32.Parse(txtBoxMaDocGia.Text);
            docGia.tenDocGia = txtBoxThemTenDocGia.Text;
            docGia.donVi = txtBoxThemDonVi.Text;
            docGia.ngaySinh = dateTimeNgaySinh.Text.Length != 0 
                ?  DateTime.Parse(dateTimeNgaySinh.Text) : DateTime.Now;
            docGia.sdt = txtBoxThemSdt.Text.Length != 0 
                ? Int32.Parse(txtBoxThemSdt.Text) : 0;
            docGia.queQuan = txtBoxThemQuequan.Text;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(docGia);
            if (new GlobalVariable().PostApi(GlobalVariable.url + "api/themdocgia", json))
            {
                if (!docGiaBLL.ThemDocGia(docGia))
                {
                    MessageBox.Show("Độc giả này bị trùng mã độc giả trong Database");
                    return;
                }
                MessageBox.Show("Thêm thành công");
                Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                Close();
            }
            //if(!docGiaBLL.ThemDocGia(docGia))
            //{
            //    MessageBox.Show("Độc giả này bị trùng mã độc giả trong Database");
            //    return;
            //}

            //string json = JsonConvert.SerializeObject(docGia);
            ////string json1 = JsonSerializer.Serialize(docGia);

            ////string postData = "ver=1&cmd=abf";
            //byte[] byteArray = Encoding.UTF8.GetBytes(json);

            //// Post the data to the right place.
            //Uri target = new Uri("https://localhost:44353/api/themdocgia");
            //WebRequest request = WebRequest.Create(target);

            //request.Method = "POST";
            //request.ContentType = "application/x-www-form-urlencoded";
            //request.ContentLength = byteArray.Length;

            //using (var dataStream = request.GetRequestStream())
            //{
            //    dataStream.Write(byteArray, 0, byteArray.Length);
            //}

            //using (var response = (HttpWebResponse)request.GetResponse())
            //{
            //    int kq = command.ExecuteNonQuery();
            //    return kq > 0;
            //}

            //Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
