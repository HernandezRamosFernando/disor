import Texto_plano.Texto_plano;
import Alfabeto_ingles.Alfabeto_ingles;
import Cifrados.*;
import javax.swing.*;


var alfabeto_ingles = Alfabeto_ingles();

var cifrado_cesar = Cifrado_cesar(alfabeto_ingles,0);

var texto_plano = Texto_plano("");

var cifrado_inverso = Cifrado_inverso();

var cifrado_grupos_inverso = Cifrado_grupos_inverso(0);




fun main(args:Array<String>){
    val frame = JFrame("Cifrado");
    frame.contentPane = gui().panel1;
    frame.defaultCloseOperation = JFrame.EXIT_ON_CLOSE;
    frame.pack();
    frame.isVisible = true;



}