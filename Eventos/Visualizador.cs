using System;

namespace Eventos
{
    public class Visualizador : IVisualizador
    {
        public void VisualizarResultado(string cEvento, string cResultado)
        {
            Console.WriteLine("El evento: {0} ", cEvento, cResultado);
        }
    }
}
