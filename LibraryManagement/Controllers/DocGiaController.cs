using LibraryManagement.DTO.DocGia;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryManagement.Controllers
{
    public class DocGiaController : ApiController
    {
        DocGiaAccess docGiaAccess = new DocGiaAccess();
        [HttpGet]
        [Route("api/listdocgia")]
        public List<DocGia> ListDocGia()
        {
            return docGiaAccess.HienThiGiaoDienDocGia().ToList();
        }
        [HttpGet]
        [Route("api/chitietdocgia/{madocgia}")]
        public DocGia ChiTietDocGia(int maDocGia)
        {
            return docGiaAccess.ThongTinChiTietDocGia(maDocGia);
        }
        public string strConn = @"Data Source=CTO-TaQuocHung;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        protected SqlConnection conn = null;
        public void OpenConnection()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch
            {

            }
        }
        [HttpGet]
        [Route("api/listsachdangmuon/{maDocGia}")]
        public List<SachDangMuon> ListSachDangMuon(int maDocGia)
        {
            return docGiaAccess.HienThiListSachDangMuon(maDocGia);
        }
        [HttpPost]
        [Route("api/themdocgia")]
        public bool AddDocGia(DocGia docGia)
        {
            return docGiaAccess.ThemDocGia(docGia);
        }
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}