using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodelavida
{
    class determinartamaño : espacio
    {
        public int determinarTamañox()
        {
            int x = (2 * margenHorizontal) + (columnas * anchoCelda);
                Console.Write(x);
            return x;

        }
        public int determinarTamañoy()
        {
            return (2 * margenVertical) + (filas * anchoCelda);

        }
    }
}
