using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBCCSLN
{
    public class ConversorGrandezas
    {
        public decimal Converter(decimal valor, string tipoUnidade)
        {
            if (tipoUnidade == "Bilhoes")
            {
                return valor / 1000000000m;
            }
            else if (tipoUnidade == "Trilhoes")
            {
                return valor / 1000000000000m;
            }
            else if (tipoUnidade == "Milhoes")
            {
                return valor / 1000000m;
            }

            return valor;
        }
    }
}
