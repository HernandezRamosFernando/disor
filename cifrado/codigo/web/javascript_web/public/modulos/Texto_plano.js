

class Texto_plano{


constructor(texto){

    this.texto = texto;
}



getTexto(){
    return this.texto;
}

setTexto(texto){
    this.texto = texto;
}

agregar_elemento(caracter){
  this.texto += caracter;
}


eliminar_ultimo_elemento(){
    this.texto = this.texto.substring(0,this.texto.length-1);
}


numero_elementos(){
    return this.texto.length;
}


hay_elemento_en_posicion(posicion){
      if(this.texto[posicion]!==undefined){

        return true;
      }

      else{
          return false;
      }
}


elemento_en_posicion(posicion){

    return this.texto[posicion];
}


texto_en_grupos(tamano_grupo){
var respuesta = new Array();
var grupo_aux="";
for(var i=0;i<this.numero_elementos();i++){
grupo_aux+=this.elemento_en_posicion(i);

if(grupo_aux.length==tamano_grupo){
respuesta.push(grupo_aux);
grupo_aux="";
}
}

return respuesta;
    
}




}

module.exports = Texto_plano;