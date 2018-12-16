package Alfabeto_ingles;
import Alfabeto.*;

class Alfabeto_ingles:Alfabeto {


    val alfabeto:String;

    constructor(){
        this.alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    }

    override fun caracter_en_alfabeto(caracter: Char): Boolean {
        return this.alfabeto.indexOf(caracter)>=0;
    }

    override fun numero_caracteres(): Int {
        return this.alfabeto.length;
    }

    override fun caracter_en_posicion(posicion: Int): Char {
        return this.alfabeto.get(posicion);
    }

    override fun posicion_de_caracter(caracter: Char): Int {
        return this.alfabeto.indexOf(caracter);
    }





}