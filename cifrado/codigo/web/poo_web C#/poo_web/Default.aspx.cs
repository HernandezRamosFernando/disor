using System;
using System.Web;
using System.Web.UI;
using Cifrado_cesar_poo_desktop.Texto_plano;
using Cifrado_cesar_poo_desktop.Alfabeto_ingles;
using Cifrado_cesar_poo_desktop.Cifrados;
namespace poo_web
{

    public partial class Default : System.Web.UI.Page
    {
        private Texto_plano texto_plano = new Texto_plano("");
        private static Alfabeto_ingles alfabeto_ingles = new Alfabeto_ingles();
        private Cifrado_cesar cifrado_cesar = new Cifrado_cesar(alfabeto_ingles,0);


        public void texto_TextChanged(object sender, EventArgs args)
        {

            //texto_plano.agregar_texto(texto.Text);
            //cifrado_cesar.cambiar_desplazamiento(Int16.Parse(desplazamiento.Text));
            //texto_cifrado.Text = cifrado_cesar.cifrar_texto(texto_plano).obtener_texto();
            //Console.WriteLine(texto_plano.obtener_texto());
            Console.WriteLine("hola");

        }
    }
}
