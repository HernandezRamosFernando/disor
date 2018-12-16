

<?php

class Cifrado_cesar{
    private $alfabeto;


    public function __construct($alfabeto){
        $this->alfabeto = $alfabeto;
    }

    public function cifrar_letra($caracter,$desplazamiento){
        if($this->alfabeto->elemento_en_alfabeto($caracter)){
            if($this->alfabeto->posicion_elemento($caracter)+$desplazamiento<$this->alfabeto->numero_elementos()){
                return $this->alfabeto->elemento_en_posicion($this->alfabeto->posicion_elemento($caracter)+$desplazamiento);
            }

            else{
                return $this->alfabeto->elemento_en_posicion(($this->alfabeto->posicion_elemento($caracter)+$desplazamiento)%$this->alfabeto->numero_elementos());
            }
        }

        else{
            return $caracter;
        }
    }



    public function cifrar_texto($texto,$desplazamiento){
        $texto_cifrado = "";
        foreach(str_split($texto->getTexto()) as $caracter){
            $texto_cifrado.=$this->cifrar_letra($caracter,$desplazamiento);
        }

        return $texto_cifrado;
    }


   
}


?>