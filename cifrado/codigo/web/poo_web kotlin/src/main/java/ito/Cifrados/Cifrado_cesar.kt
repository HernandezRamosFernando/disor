package Cifrados
import Texto_plano.*;
import Alfabeto.*;

class Cifrado_cesar {

    private var desplazamiento:Int;
    private var alfabeto:Alfabeto;

    constructor(alfabeto:Alfabeto,desplazamiento:Int){
        this.desplazamiento = desplazamiento;
        this.alfabeto = alfabeto;
    }

    private fun cifrar_caracter(caracter:Char):Char{
        if(this.alfabeto.caracter_en_alfabeto(caracter)){
            if((this.alfabeto.posicion_de_caracter(caracter)+desplazamiento)<this.alfabeto.numero_caracteres()){
                return this.alfabeto.caracter_en_posicion(this.alfabeto.posicion_de_caracter(caracter)+desplazamiento);
            }
            else{
                return this.alfabeto.caracter_en_posicion((this.alfabeto.posicion_de_caracter(caracter)+desplazamiento)%this.alfabeto.numero_caracteres());
            }
        }

        else{
            return caracter;
        }
    }

    public fun modificar_desplazamiento(desplazamiento:Int){
        this.desplazamiento = desplazamiento;
    }


    public fun cifrar_texto(texto:Texto_plano):Texto_plano{
        var texto_cifrado = Texto_plano("");

        var iterador = texto.obtener_texto().iterator();

        while (iterador.hasNext()){
            texto_cifrado.agregar_caracter(this.cifrar_caracter(iterador.next()));
        }

        return  texto_cifrado;
    }
}