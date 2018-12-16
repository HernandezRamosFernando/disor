package Alfabeto

interface Alfabeto {

    fun numero_caracteres():Int;
    fun caracter_en_posicion(posicion:Int):Char;
    fun posicion_de_caracter(caracter:Char):Int;
    fun caracter_en_alfabeto(caracter:Char):Boolean
}