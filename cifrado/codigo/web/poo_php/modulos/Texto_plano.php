<?php


class Texto_plano{

   private $texto;


   public function __construct($texto){
    $this->texto = $texto;
    }


    public function numero_elementos(){
        return strlen($this->texto);
    }

    public function getTexto(){
        return $this->texto;
    }


    public function setTexto($texto){
        $this->texto = $texto;
    }


    public function agregar_elemento($caracter){
        $this->texto.=$caracter;
    }

    public function eliminar_ultimo_elemento(){
        $this->texto = substr($this->texto,0,-1);
    }


    public function hay_elemento_en_posicion($posicion){
        if($posicion<strlen($this->texto)){
            return true;
        }
        else{
            return false;
        }
    }


    public function elemento_en_posicion($posicion){
        return $this->texto[$posicion];
    }

    public function separar_en_grupos($grupos){
        $aux_grupos = "";
        $texto_en_grupos = array();
        for($i=0;$i<strlen($this->texto);$i++){
            $aux_grupos.=$this->texto[$i];
            if(strlen($aux_grupos)==$grupos){
                array_push($texto_en_grupos,$aux_grupos);
                $aux_grupos = "";
            }
        }

        return $texto_en_grupos;
    }


}


    


?>