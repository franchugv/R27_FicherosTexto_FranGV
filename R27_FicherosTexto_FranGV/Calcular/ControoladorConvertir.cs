using R27_FicherosTexto_FranGV.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R27_FicherosTexto_FranGV.Calcular
{
    public enum OpcionesConversion :byte { Salir, EuroDolar, DolarEuro }
    public static class ControoladorConvertir
    {
        public static void ControladorC()
        {
            // Recursos

            float dato = 0;
            OpcionesConversion opcion = OpcionesConversion.Salir;
            bool esValido;
            string merror = "";

            do
            {

                Calcular.UIConvertir.MenuConvertir();


                esValido = true;

                opcion = (OpcionesConversion)Metodos.CaptarOpcionEnum((byte)Enum.GetValues<OpcionesConversion>().Length);

                try
                {
                    switch (opcion)
                    {
                        case OpcionesConversion.Salir:
                            break;
                        case OpcionesConversion.EuroDolar:
                            dato = Calcular.LogicaNegocio.CalculoConversion(dato, Fichero.APIFichero.ObtenerEuroADolar(), "Euros");
                            break;
                        case OpcionesConversion.DolarEuro:
                            dato = Calcular.LogicaNegocio.CalculoConversion(dato, Fichero.APIFichero.ObtenerDolaraEuro(), "Dolares");
                            break;
                    }

                }
                catch (Exception error)
                {
                    esValido = false;
                    merror = error.Message;
                }
                finally
                {
                    if (!esValido) Metodos.MostrarError(merror);
                    Metodos.MostrarDatos(dato.ToString());
                }
            }
            while (!esValido || opcion != OpcionesConversion.Salir);
        }
    }
}
