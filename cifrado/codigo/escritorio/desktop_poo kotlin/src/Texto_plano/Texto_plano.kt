package Texto_plano

class Texto_plano:Texto.Texto {

    private var texto:String = "";

    constructor(texto:String){
        this.texto = texto;
    }

    override fun numero_caracteres(): Int {
        return this.texto.length;
    }

    override fun obtener_texto(): String {
        return this.texto;
    }

    override fun agregar_grupos_caracteres(grupo_caracteres: String) {
        this.texto+=grupo_caracteres;
    }

    override fun caracter_en_posicion(posicion: Int): Char {
        return this.texto.get(posicion);
    }

    override fun posicion_de_caracter(caracter: Char): Int {
        return this.texto.indexOf(caracter);
    }

    override fun hay_caracter_en_posicion(posicion: Int): Boolean {
        return posicion<this.numero_caracteres();
    }

    override fun agregar_caracter(caracter: Char) {
        this.texto+=caracter;
    }

    override fun eliminar_ultimo_caracter() {
        this.texto = this.texto.substring(0,numero_caracteres()-1);
    }

    override fun texto_en_grupos(grupos: Int): ArrayList<String> {
        var texto_en_grupos_respuesta:ArrayList<String> = ArrayList();
        var grupo_auxiliar = "";

        var iterador = this.texto.iterator();
        while (iterador.hasNext()){
            grupo_auxiliar+=iterador.next();
            if(grupo_auxiliar.length==grupos){
                texto_en_grupos_respuesta.add(grupo_auxiliar);
                grupo_auxiliar = "";
            }
        }

        return texto_en_grupos_respuesta;
    }
}