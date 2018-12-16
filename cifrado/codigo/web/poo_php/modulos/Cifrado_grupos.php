<?php

class Cifrado_grupos{

    public function cifrar_texto($texto,$grupos){
        $texto_cifrado = "";
        foreach($texto->separar_en_grupos($grupos) as $grupo){
            $texto_cifrado.= strrev($grupo);
        }

        return $texto_cifrado;
    }
}


?>