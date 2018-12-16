<?php


class Cifrado_inverso{

    public function cifrar_texto($texto){
        return strrev($texto->getTexto());
    }

}




?>