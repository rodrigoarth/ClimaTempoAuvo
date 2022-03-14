using ClimaTempo.Models;
using ClimaTempo.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace ClimaTempo.Repository
{
    public class ClimaTempoRepository : IClimaTempo
    {
        private readonly ClimaTempoContext _context;
        public ClimaTempoRepository(ClimaTempoContext context)
        {
            _context = context;
        }
        public List<PrevisaoClima> GetMaxTemp(DateTime dateTime)
        {   
            var maxTemp = _context.PrevisaoClimas.OrderByDescending(c => c.TemperaturaMaxima)
                    .Where(date => date.DataPrevisao == dateTime)
                    .Take(3)
                    .ToList();

            return (maxTemp);
        }

        public List<PrevisaoClima> GetMinTemp(DateTime dateTime)
        {
            var minTemp = _context.PrevisaoClimas.OrderBy(c => c.TemperaturaMinima)
                .Where(date => date.DataPrevisao == dateTime)
                .Take(3)
                .ToList();

            return (minTemp);
        }

        public List<PrevisaoClima> GetPrevisoes(int idCidade) 
        {
               var previsao = _context.PrevisaoClimas.Where(x => x.CidadeId == idCidade)
                .ToList();
               return previsao;
        }
    }
}