using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimaTempo.Models;

namespace ClimaTempo.Repository
{
    public interface IClimaTempo
    {
        List<PrevisaoClima> GetMaxTemp(DateTime date);
        List<PrevisaoClima> GetMinTemp(DateTime date);
        List<PrevisaoClima> GetPrevisoes(int idCidade);


    }
}
