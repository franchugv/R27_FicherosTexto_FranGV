﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R27_FicherosTexto_FranGV.Fichero
{
    public static class MetodosFichero
    {
        public static void Agregar(StreamWriter User)
        {
            string cadena;

            cadena = Metodos.CaptarCadena();

            User = File.CreateText(cadena);
        }

        public static void Modificar(StreamWriter User) 
        { 
            
        }

        public static void AñadirCantidad(StreamWriter User)
        {
            float cantidad = 0;

            cantidad = Metodos.CaptarNum();

         
        }
    }
}
