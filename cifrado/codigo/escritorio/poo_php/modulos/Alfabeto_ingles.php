<?php
require "Alfabeto.php";

class Alfabeto_ingles implements Alfabeto{

    private $alfabeto;

    public function __construct(){
        $this->alfabeto = "abcdefghijklmnopqrstuvwxyz";
    }


    public function numero_elementos(){
        return strlen($this->alfabeto);
    }


    public function elemento_en_alfabeto($caracter){
        if(strpos($this->alfabeto,$caracter)!==false){
            return true;
        }

        else{
            return false;
        }
    }


    public function posicion_elemento($caracter){
        return strpos($this->alfabeto,$caracter);
    }


    public function elemento_en_posicion($posicion){
        return $this->alfabeto[$posicion];
    }






}



?>