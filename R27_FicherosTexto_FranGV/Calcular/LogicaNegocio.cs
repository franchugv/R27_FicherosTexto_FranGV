using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R27_FicherosTexto_FranGV.Principal;

namespace R27_FicherosTexto_FranGV.Calcular
{
    public static class LogicaNegocio
    {
        public static float CalcularEurosaDolar()
        {
            // Recursos 

            float num;
            float calculo;

            num = Metodos.CaptarNum("la cantidad en Euros");
            calculo = Fichero.APIFichero.ObtenerEuroADolar();

            num = num * calculo;

            return num;
        }




        public static float CalcularDolaraEuros()
        {
            // Recursos 

            float num;
            float calculo;

            num = Metodos.CaptarNum("la cantidad en Dolares");
            calculo = Fichero.APIFichero.ObtenerDolaraEuro();

            num = num * calculo;

            return num;
        }
        
        public static float CalculoConversion(float num, float conversion, string text)
        {
            float calculo;

            num = Metodos.CaptarNum($"la cantidad en {text}");
            calculo = conversion;

            num = num * calculo;

            return num;
        }


       
    }
}
