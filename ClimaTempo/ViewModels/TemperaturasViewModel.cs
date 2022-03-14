using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClimaTempo.Models;

namespace ClimaTempo.ViewModels
{
    public class TemperaturasViewModel
    {
        public List<PrevisaoClima> TempMax { get; set; }
        public List<PrevisaoClima> TempMin { get; set; }
        public Estado EstadoNm { get; set; }
    }



}