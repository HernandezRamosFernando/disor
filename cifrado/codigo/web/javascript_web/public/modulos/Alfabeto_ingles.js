

class Alfabeto_ingles{

constructor(){
  this.alfabeto = "abcdefghijklmnopqrstuvwxyz";
}


elemento_en_posicion(posicion){

    return this.alfabeto[posicion];
}

elemento_en_alfabeto(caracter){

    if(this.alfabeto.indexOf(caracter)>=0){

        return true;
    }

    else{
        return false;
    }
}


posicion_elemento(caracter){

    return this.alfabeto.indexOf(caracter);
}


numero_elementos(){
    return this.alfabeto.length;
}
    
}

module.exports = Alfabeto_ingles;

