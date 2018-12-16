package Cifrados

import Cifrado.Cifrado;
import Texto.Texto
import  Texto_plano.*;

class Cifrado_inverso:Cifrado {

    override fun cifrar_texto(texto: Texto): Texto {
        return Texto_plano(texto.obtener_texto().reversed());
    }
}