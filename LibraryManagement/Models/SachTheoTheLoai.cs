using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class SachTheoTheLoai
    {
        public int MaTheLoai {  get;set;  }
        public string TenTheLoai { get; set; }
        public String MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        public string TenTacGia { get; set; }
        public int Tap { get; set; }
        public int SoLuong { get; set; }
    }
}
