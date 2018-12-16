

class Cifrado_cesar{


constructor(alfabeto){
    this.alfabeto = alfabeto;
}

cifrar_letra(caracter,desplazamiento){
if(this.alfabeto.elemento_en_alfabeto(caracter)){
    
    if(this.alfabeto.posicion_elemento(caracter)+desplazamiento<this.alfabeto.numero_elementos()){

        return this.alfabeto.elemento_en_posicion(this.alfabeto.posicion_elemento(caracter)+desplazamiento);
    }

    else{
        return this.alfabeto.elemento_en_posicion(((this.alfabeto.posicion_elemento(caracter)+desplazamiento)%this.alfabeto.numero_elementos()));
    }
    

}

else{
    return caracter;
}
}


cifrar_texto(texto,desplazamiento,indice_texto,texto_cifrado){
if(!texto.hay_elemento_en_posicion(indice_texto)){
return texto_cifrado;
}

else{
    texto_cifrado+= this.cifrar_letra(texto.elemento_en_posicion(indice_texto),desplazamiento);
}

return this.cifrar_texto(texto,desplazamiento,indice_texto+1,texto_cifrado);
}




}

module.exports = Cifrado_cesar;

