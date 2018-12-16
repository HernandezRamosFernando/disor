<?php
require 'Texto_plano.php';
require "Alfabeto_ingles.php";
require "Cifrado_cesar.php";
require "Cifrado_inverso.php";
require "Cifrado_grupos.php";

$texto_plano = new Texto_plano("hola a todos");


$alfabeto_ingles = new Alfabeto_ingles();


$cifrado_cesar = new Cifrado_cesar($alfabeto_ingles);
echo $cifrado_cesar->cifrar_texto($texto_plano,5);

$cifrado_inverso = new Cifrado_inverso();
echo $cifrado_inverso->cifrar_texto($texto_plano);


$cifrado_grupos = new Cifrado_grupos();
echo $cifrado_grupos->cifrar_texto($texto_plano,2);
?>