using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using LibraryManagement.Models;
using LibraryManagement.DTO.TheLoai;

namespace LibraryManagement.Controllers
{
    public class ThongKeController : ApiController
    {
        TheLoaiAccess theloaiaccess = new TheLoaiAccess();
        DauSachAccess dausachaccess = new DauSachAccess();

        // GET: api/ThongKe
        [HttpGet]
        [Route("api/TheLoai")]
        public List<TheLoai> Get_TheLoai()
        {
            return theloaiaccess.LayDanhSachTheLoai().ToList();
            
        }


        [HttpGet]
        [Route("api/PhanLoai")]
        public List<SachTheoTheLoai> Get_PhanLoai(string name)
        {
            return dausachaccess.DanhSachDauSachTheoTheLoai(name).ToList();
        }


        // GET: api/ThongKe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ThongKe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ThongKe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ThongKe/5
        public void Delete(int id)
        {
        }
    }
}
