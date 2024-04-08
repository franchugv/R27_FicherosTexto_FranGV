using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R27_FicherosTexto_FranGV.Fichero
{
    public static class APIFichero
    {


        const string RUTA = "config.ead";

        public static float ObtenerEruroADolar()
        {
            string aux;
            StreamReader lector;
            float dato = 0.0f;
            // Validar si el fichero existe
            if (!File.Exists(RUTA)) CrearFichero();

            lector = File.OpenText(RUTA);
            aux = lector.ReadLine();    // Asignar contenido del fichero a aux
            lector.Close();

            dato = Convert.ToSingle(aux);

            return dato;
        }


        public static float ObtenerDolaraEuro()
        {
            string aux;
            StreamReader lector;
            float dato = 0.0f;
            // Validar si el fichero existe

            if (!File.Exists(RUTA)) CrearFichero();

            lector = File.OpenText(RUTA);
            lector.ReadLine();       // Hacemos esto para acceder a la segunda línea
            aux = lector.ReadLine();    // Asignar contenido del fichero a aux
            lector.Close();

            dato = Convert.ToSingle(aux);

            return dato;
        }


        public static void ModificarDatos(float euroDolar, float DolarEuro)
        {
            StreamWriter escritor;

            escritor = File.CreateText(RUTA);
            escritor.WriteLine(euroDolar);
            escritor.WriteLine(DolarEuro);
            escritor.Close();
        }


        public static void CrearFichero()
        {
            const float EURODOOLAR = 1.3635f;
            const float DOLAREURO = 0.7334f;

            StreamWriter escritor;

            escritor = File.CreateText(RUTA);
            escritor.WriteLine(EURODOOLAR);
            escritor.WriteLine(DOLAREURO);
            escritor.Close();
        }

        public static string ConsultarFichero()
        {
            StreamReader Lector;
            string cadena;

            Lector = File.OpenText(RUTA);
            cadena = Lector.ReadLine();
            cadena += "\n";
            cadena += Lector.ReadLine();

            return cadena;
           
        }
    }
}
