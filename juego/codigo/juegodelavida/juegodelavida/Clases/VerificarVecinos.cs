using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodelavida
{
    class VerificarVecinos
    {
        public int actualizarVecinos(int fila, int columna, bool[,] estado, int filas, int columnas)
        {
            int res = 0;
            //Cuenta las vecinos que rodean al individuo situado en [fila,columna]
            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                    if (i != 0 || j != 0)
                        if (estado[(filas + fila + i) % filas, (columnas + columna + j) % columnas] == true)
                            res++;
            return res;
        }
    }
}
