using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodelavida
{
    class espacio
    {

        public espacio()
        {
            margenHorizontal = 20;
            margenVertical = 30;
            filas = 90;
            columnas = 90;
            anchoCelda = 6;

        }

        public int margenHorizontal { get; set; }
        public int margenVertical { get; set; }
        public int filas { get; set; }
        public int columnas { get; set; }
        public int anchoCelda { get; set; }


       
    }

   

}
