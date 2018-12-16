using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodelavida
{
    class reglas : espacio
    {

        public reglas()
        {
        }

        public bool calculareglas(int fila, int columna, bool[,]estado)
        {
            bool res = false;
            //Número de vecinos 
            VerificarVecinos verificarvecinos = new VerificarVecinos();
            
            int numVecinos = verificarvecinos.actualizarVecinos(fila, columna, estado, filas, columnas);
            res = estado[fila, columna];

            //Aplicamos reglas:

            //Un individuo nace si hay 3 vecinos vivos
            if (numVecinos == 3)
                res = true;

            //Si un individuo no tiene 2 ó 3 vecinos muere
            if (numVecinos != 2 &&
                numVecinos != 3)
                res = false;

            return res;
        }

    }
}
