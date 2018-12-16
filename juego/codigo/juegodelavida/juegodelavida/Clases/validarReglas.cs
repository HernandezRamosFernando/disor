using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodelavida
{
    class validarReglas 
    {
        public bool[,] validarReglasEjecutando( int filas, int columnas, bool[,]estado)
        {
            bool[,] estadoAux = new bool[filas, columnas];
            reglas reglas = new reglas();
            reglas.columnas = filas ;
            reglas.filas = columnas;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    estadoAux[i, j] = reglas.calculareglas(i, j,estado);
                }
            }
            return estadoAux;
        }
    }
}
