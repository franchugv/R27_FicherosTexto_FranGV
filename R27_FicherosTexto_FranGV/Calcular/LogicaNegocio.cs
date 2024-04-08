using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R27_FicherosTexto_FranGV.Calcular
{
    public static class LogicaNegocio
    {
        public static float CalcularEurosaDolar()
        {
            // Recursos 

            float num;
            float calculo;

            num = Metodos.CaptarNum("la cantidad que en Euros");
            calculo = Fichero.APIFichero.ObtenerEruroADolar();

            num = num * calculo;

            return num;
        }


        public static float CalcularDolaraEuros()
        {
            // Recursos 

            float num;
            float calculo;

            num = Metodos.CaptarNum("la cantidad que en Dollares");
            calculo = Fichero.APIFichero.ObtenerDolaraEuro();

            num = num * calculo;

            return num;
        }
    }
}
