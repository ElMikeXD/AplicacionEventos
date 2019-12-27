using System;

namespace Eventos
{
    public class Visualizador : IVisualizador
    {
        public void VisualizarResultado(string cEvento, string cTiempo, string cResultado)
        {
            Console.WriteLine("El evento: {0} {1} {2}", cEvento, cTiempo, cResultado);
        }
    }
}
