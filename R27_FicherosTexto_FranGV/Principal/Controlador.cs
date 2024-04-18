using R27_FicherosTexto_FranGV.Calcular;
using R27_FicherosTexto_FranGV.Fichero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R27_FicherosTexto_FranGV.Principal
{
    public enum OpcionesPrincipal :byte { Salir, Consultar, Modificar, Convertir }
    public static class Controlador
    {
        public static void ControladorPrincipal()
        {
            OpcionesPrincipal opcion = OpcionesPrincipal.Salir;
            bool esValido;
            string mensaje = "";

            do {
                UIPrincipal.MenuPrincipal();
                esValido = true;
                try {

                    opcion = (OpcionesPrincipal)Metodos.CaptarOpcionEnum((byte)Enum.GetValues<OpcionesPrincipal>().Length);


                    switch (opcion)
                    {
                        case OpcionesPrincipal.Salir:
                            break;
                        case OpcionesPrincipal.Consultar:
                            Metodos.MostrarDatos(APIFichero.ConsultarFichero());
                            Metodos.Pausa();
                            break;
                        case OpcionesPrincipal.Modificar:
                            ControladorModificar.ControladorModificar.ControladorM();
                            break;
                        case OpcionesPrincipal.Convertir:
                            Calcular.ControoladorConvertir.ControladorC();
                            break;


                          

                    }

                }
                catch (Exception error)
                {
                    esValido = false;
                    mensaje = error.Message;
                }
                finally
                {
                    if(!esValido) Metodos.MostrarError(mensaje);
                }
            } while (!esValido || opcion != OpcionesPrincipal.Salir);

        }
    }
}
