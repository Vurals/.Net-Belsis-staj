using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private readonly WebApplication1Context _context;
        public ValuesController(WebApplication1Context context)
        {
            _context = context;
            
            if (_context.Yer_imi.Count() == 0)
            {
                _context.SaveChanges();
                
            }
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public JsonResult Get()
        {
            var _coords = _context.Yer_imi.ToList();
            return Json(_coords);
        }
        
        public JsonResult Post()
        {
            return Json("");
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       // 
        // POST api/<ValuesController>
        [HttpPost]
        public JsonResult Post(Yer_imi kapi)
        {
            
            if (ModelState.IsValid)
            {
                _context.Yer_imi.Add(kapi);
                _context.SaveChanges();
            }
            return Json("");
            
        }

        // DELETE api/<ValuesController>/5
       [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var _deleted =_context.Yer_imi.Find(id);
            _context.Yer_imi.Remove(_deleted);
            _context.SaveChanges();
        }


        //[HttpPost]
        //public JsonResult BilgiVer(int? id)
        //{

        //    if (id == null)
        //    {
        //        return Json(new { hata = "ID Bilgisi Gönderilmedi" });
        //    }

        //        Yer_imi yer_imi = _context.Yer_imi.Find(id);

        //        if (yer_imi == null)
        //        {
        //            return Json(new { hata = "Bilgi Bulunamadı" });
        //        }
        //        else
        //        {
        //            return Json(new { bilgi = yer_imi });
        //        }
        //}
        // PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

    }
}
