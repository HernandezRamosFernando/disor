package Texto

interface Texto {
    fun numero_caracteres():Int;
    fun obtener_texto():String;
    fun agregar_grupos_caracteres(grupo_caracteres:String);
    fun caracter_en_posicion(posicion:Int):Char;
    fun posicion_de_caracter(caracter:Char):Int;
    fun hay_caracter_en_posicion(posicion:Int):Boolean;
    fun agregar_caracter(caracter:Char);
    fun eliminar_ultimo_caracter();
    fun texto_en_grupos(grupos:Int):ArrayList<String>;

}






