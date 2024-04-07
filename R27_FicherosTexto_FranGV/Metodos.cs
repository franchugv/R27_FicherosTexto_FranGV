﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R27_FicherosTexto_FranGV
{
    public static class Metodos
    {
        public static float CaptarNum()
        {
            // Recursos

            string aux = "";
            float cantidad = 0;
            string mError = "";
            bool esCorrecto;


            do
            {
                esCorrecto = true;
                try
                {
                    esCorrecto = true;


                    Console.Write("Escriba una cantidad: ");

                    aux = Console.ReadLine();

                    if (string.IsNullOrEmpty(aux)) throw new FormatException("Cadena vacía");

                    cantidad = Convert.ToSingle(aux);

                }
                catch(Exception error) 
                { 
                    mError = error.Message;
                    esCorrecto = false;
                }
                finally
                {
                    if (!esCorrecto) MostrarError(mError);
                }
            } while (!esCorrecto);

            return cantidad;
        }


        public static string CaptarCadena()
        {
            // Recursos

            string cadena = "";
            string mError = "";
            bool esCorrecto;


            do
            {
                esCorrecto = true;
                try
                {
                    esCorrecto = true;


                    Console.Write("Escriba una cantidad: ");

                    cadena = Console.ReadLine();

                    if (string.IsNullOrEmpty(cadena)) throw new FormatException("Cadena vacía");


                }
                catch (Exception error)
                {
                    mError = error.Message;
                    esCorrecto = false;
                }
                finally
                {
                    if (!esCorrecto) MostrarError(mError);
                }
            } while (!esCorrecto);

            return cadena;
        }


        public static void MostrarError(string error)
        {
            Console.WriteLine($"Error: {error}");
            Console.WriteLine("Pulse Enter para continuar... ");
            Console.ReadLine();
            Console.Clear();
        }

        public static byte CaptarOpcionEnum(byte NumElementos)
        {
            // El NumElementos debe ser el Length del Enum
            // RECURSOS

            byte opcion = 0;
            string aux = "";

            // ENTRADA

            aux = Console.ReadLine();

            // VALIDACIÓN

            if (string.IsNullOrEmpty(aux)) throw new FormatException();

            // Preparación de la cadena, dejarla sin espacios laterales

            aux = aux.Trim();

            // CONVERSIÓN

            opcion = Convert.ToByte(aux);

            // VALIDACIÓN de que no supere el número de elementos

            if (opcion >= NumElementos) throw new OverflowException();



            // SALIDA

            return opcion;

        }
    }
}