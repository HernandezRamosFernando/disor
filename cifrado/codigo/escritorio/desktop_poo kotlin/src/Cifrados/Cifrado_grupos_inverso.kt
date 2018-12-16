package Cifrados

import Cifrado.Cifrado;
import Texto.Texto
import Texto_plano.Texto_plano;
import Cifrados.Cifrado_inverso;

class Cifrado_grupos_inverso:Cifrado {

    private val cifrado_inverso:Cifrado_inverso;
    private var grupos:Int;

    constructor(grupos:Int){
        this.grupos = grupos;
        this.cifrado_inverso = Cifrado_inverso();
    }

    override fun cifrar_texto(texto: Texto): Texto {
        var texto_cifrado = Texto_plano("");
        var iterador = texto.texto_en_grupos(this.grupos).iterator();
        while(iterador.hasNext()){
            texto_cifrado.agregar_grupos_caracteres(this.cifrado_inverso.cifrar_texto(Texto_plano(iterador.next())).obtener_texto())
        }

        return texto_cifrado;
    }

    public fun cambiar_grupo(grupo:Int){
        this.grupos = grupo;
    }
}