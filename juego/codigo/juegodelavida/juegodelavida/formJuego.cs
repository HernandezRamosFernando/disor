using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


//creado por Fernando Hernández Ramos y Christian Sánchez Hernández
namespace juegodelavida
{
    public partial class formJuego : Form
    {
        private bool[,] estado;

        public formJuego()
        {
            InitializeComponent();
            espacio espacio = new espacio();
            crearIndividuos crearindividuos = new crearIndividuos();
            determinartamaño determinartamaño = new determinartamaño();

            //Funcion para evitar que la pantalla se recargue y alente
            this.SetStyle(
            ControlStyles.DoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.ResizeRedraw,
            true);

            //Actualizar la pantalla
            this.UpdateStyles();

            //Funcion para establecer el tamaño de la ventana deseada
            SetClientSizeCore(determinartamaño.determinarTamañox(), determinartamaño.determinarTamañoy());

            //Inicializar los individuos
            estado = new bool [crearindividuos.filas, crearindividuos.columnas];
        }

     
        private void formJuego_Paint(object sender, PaintEventArgs e)
        {
            espacio espac = new espacio();
            //Dibujar el espacio de juego
            Graphics crearventana = e.Graphics;
            for (int i = 0; i < espac.filas; i++)
            {
                for (int j = 0; j < espac.columnas; j++)
                {
                    Rectangle rectangulo =
                        new Rectangle(espac.margenHorizontal + (espac.anchoCelda * j),
                                      espac.margenVertical + 10 + (espac.anchoCelda * i),
                                      espac.anchoCelda,
                                      espac.anchoCelda);
                    crearventana.DrawRectangle(Pens.Gray, rectangulo);
                    if (estado[i, j])
                    {
                        crearventana.FillRectangle(Brushes.Black, rectangulo);
                    }
                }
            }
        }

        private void juegoFuncionando(object sender, DoWorkEventArgs e)
        {
            espacio correr = new espacio();
            backgroundWorker1.ReportProgress(0);
            Thread.Sleep(500);
            validarReglas validar = new validarReglas();
            
            while (true)
            {
                //ejecutar las reglas de los individuos en segundo plano
                bool [,]estadoAux=validar.validarReglasEjecutando(correr.filas, correr.columnas, estado);
                estado = (bool[,])estadoAux.Clone();
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(500);
            }
        }

        private void actualizacionJuego(object sender, ProgressChangedEventArgs e)
        {
            Refresh();
        }


        private void botoniniciar_Click(object sender, EventArgs e)
        {
            //Inicializamos los individous vivos 
            crearIndividuos crearaleatorio = new crearIndividuos();
            estado = crearaleatorio.inicializarAleatorio();

            //Se inicia la ejecución
            backgroundWorker1.RunWorkerAsync();
            Console.Write("Inicio");

            botoniniciar.Visible = false;
            botondetener.Visible = true;
        }

        private void botondetener_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            backgroundWorker1.Dispose();
            backgroundWorker1 = null;
            Console.Write("detenido");
            botondetener.Visible = false;
            botonreiniciar.Visible = true;
        }

        private void botonreiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
