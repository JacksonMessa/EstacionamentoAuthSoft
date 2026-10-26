using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoAuthSoft.Utils
{
    internal class CalculoEstadia
    {
        public static int CalcularPermanencia(DateTime entrada)
        {
            return CalcularPermanencia(entrada,DateTime.Now);
        }

        public static int CalcularPermanencia(DateTime entrada, DateTime saida)
        {
            TimeSpan permanencia = saida - entrada;

            return (int)Math.Floor(permanencia.TotalMinutes);
        }

        public static int ObterValorEstadia(int permanencia)
        {
            if (permanencia <= 15)
            {
                return 0;
            }
            else if (permanencia <= 60)
            {
                return 10;
            }
            else
            {
                int valor = 10;
                int minutosAdicionais = permanencia - 60;
                int horasAdicionais = Convert.ToInt32(Math.Ceiling((double)minutosAdicionais/60));

                valor += horasAdicionais * 4;

                if (valor <= 40)
                {
                    return valor;
                }
                else
                {
                    return 40;
                }
            }
        }

        public static int ObterValorEstadiaEmCentavos(int permanencia)
        {
            return ObterValorEstadia(permanencia) * 100;
        }
    }
}
