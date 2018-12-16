using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodelavida
{
    class crearIndividuos : espacio
    {
        bool[,] individuos;

        public bool[,] inicializarAleatorio()
        {
            Console.Write(filas + columnas);
            individuos = new bool[filas, columnas];
            Random rand = new Random((int)DateTime.Now.Ticks);

            //Se inicializa los individuos con valores aleatorios
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    individuos[i, j] = (rand.Next(0, 100) >= 90);
                }
            }
            return individuos;
        }
    }
}
