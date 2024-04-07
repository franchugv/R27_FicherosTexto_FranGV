using R27_FicherosTexto_FranGV.Principal;

namespace R27_FicherosTexto_FranGV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RECURSOS

            StreamWriter usuarioEscritor = null;
            StreamReader usuarioLector = null;


            // Controlador

            Controlador.ControladorPrincipal(usuarioEscritor, usuarioLector);


        }
    }
}
