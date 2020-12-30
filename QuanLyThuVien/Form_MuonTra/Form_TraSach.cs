using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.Form_MuonTra
{
    public partial class Form_TraSach : Form
    {
        private DocGiaBLL docGiaBLL;
        public Form_TraSach()
        {
            InitializeComponent();
            docGiaBLL = new DocGiaBLL();
        }

        private void TrasachKeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (docGiaBLL.KiemTraXemSachCoTonTaikhong(txtBoxTraSach.Text))
                {
                    MessageBox.Show("Sách này không tồn tại");
                    Close();
                    return;
                }
                if (!docGiaBLL.TraSach(txtBoxTraSach.Text))
                {
                    MessageBox.Show("Sách này chưa được mượn");
                    Close();
                } else
                {
                    MessageBox.Show("Đã trả sách thành công");

                }
            }
            
            
        }
    }
}
