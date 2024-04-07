﻿using R27_FicherosTexto_FranGV.Fichero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R27_FicherosTexto_FranGV.Principal
{
    public enum OpcionesPrincipal :byte { Salir, Crear, ACantidad, Consultar, Modificar, AEuros, ADolares }
    public static class Controlador
    {
        public static void ControladorPrincipal(StreamWriter User, StreamReader UserLector)
        {
            OpcionesPrincipal opcion = OpcionesPrincipal.Salir;


            opcion = (OpcionesPrincipal)Metodos.CaptarOpcionEnum((byte)Enum.GetValues<OpcionesPrincipal>().Length);


            switch (opcion)
            {
                case OpcionesPrincipal.Salir:
                    break;
                case OpcionesPrincipal.Crear:
                    MetodosFichero.Agregar(User);
                    break;
                case OpcionesPrincipal.ACantidad:
                    break;
                case OpcionesPrincipal.Consultar:
                    break;
                case OpcionesPrincipal.Modificar:
                    MetodosFichero.Modificar(User);
                    break;
                case OpcionesPrincipal.AEuros:
                    break;
                case OpcionesPrincipal.ADolares:
                    break;
            }

        }
    }
}