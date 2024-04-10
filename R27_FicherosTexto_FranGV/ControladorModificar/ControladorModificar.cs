using R27_FicherosTexto_FranGV.Fichero;
using R27_FicherosTexto_FranGV.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R27_FicherosTexto_FranGV.ControladorModificar
{
    public static class ControladorModificar
    {


        public static void ControladorM()
        {
            // RECURSOS

            float DolarEuro;
            float EuroDolar;

            DolarEuro = Metodos.CaptarNum("el calculo de Dolar a Euros");
            EuroDolar = Metodos.CaptarNum("el cálculo de Euros a Dollares");

            APIFichero.ModificarDatos(EuroDolar, DolarEuro);
        }


    }
}
