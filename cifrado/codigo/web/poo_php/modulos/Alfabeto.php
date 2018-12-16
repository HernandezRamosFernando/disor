<?php


interface Alfabeto{

    public function numero_elementos();
    public function elemento_en_alfabeto($caracter);
    public function posicion_elemento($caracter);
    public function elemento_en_posicion($posicion);

}


?>