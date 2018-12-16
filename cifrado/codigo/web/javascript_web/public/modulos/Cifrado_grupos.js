

class Cifrado_grupos{
    

    constructor(aux_grupos,cifrado_inverso){

        this.aux_grupos = aux_grupos;
        this.cifrado_inverso = cifrado_inverso;
    }



    cifrar_texto(texto,tamano_grupo){
   
var separados = texto.texto_en_grupos(tamano_grupo);
var texto_cifrado ="";
for(var i=0;i<separados.length;i++){
    this.aux_grupos.setTexto(separados[i]);
texto_cifrado+=this.cifrado_inverso.cifrar_texto(this.aux_grupos);
}

        

        return texto_cifrado;
    }
}

module.exports = Cifrado_grupos;