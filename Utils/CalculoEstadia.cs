using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoAuthSoft.Utils
{
    internal class CalculoEstadia
    {
        public static string CalcularPermanencia(DateTime entrada)
        {
            return CalcularPermanencia(entrada,DateTime.Now);
        }

        public static string CalcularPermanencia(DateTime entrada, DateTime saida)
        {
            TimeSpan permanencia = saida - entrada;

            return (int)Math.Floor(permanencia.TotalMinutes) + " min";
        }
    }
}
