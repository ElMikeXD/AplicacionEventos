using System;

namespace Eventos
{
    public class Visualizador : IVisualizarMensajes
    {
        public void VisualizarResultado(string cEvento, string cTiempo, string cUnidadTiempo)
        {
            Console.WriteLine("El evento: {0} {1} {2}", cEvento, cTiempo, cUnidadTiempo);
        }
    }
}
