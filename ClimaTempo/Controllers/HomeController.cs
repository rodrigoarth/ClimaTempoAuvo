using ClimaTempo.Models;
using ClimaTempo.Repository;
using ClimaTempo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Configuration;


namespace ClimaTempo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClimaTempoContext _climaTempo;
        private readonly  IClimaTempo climaTempo;
        public HomeController(IClimaTempo climaTempo, ClimaTempoContext climaTempoContext)
        {
            this._climaTempo = climaTempoContext;
            this.climaTempo = climaTempo;
            
        }
        public ActionResult Index()
        {
            ViewBag.Cidades = _climaTempo.Cidades.ToList();
            DateTime date = new DateTime(2022,04,01);
            TemperaturasViewModel temperaturasViewModel = new TemperaturasViewModel()
            {
               
                TempMax= climaTempo.GetMaxTemp(date),
                TempMin= climaTempo.GetMinTemp(date),
            };


            return View(temperaturasViewModel);
        }

       [System.Web.Mvc.HttpPost]
        public JsonResult GetData([FromBody] int id)
        {
            var objPrevisao = climaTempo.GetPrevisoes(id);
            
            return Json(objPrevisao,JsonRequestBehavior.AllowGet);
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}