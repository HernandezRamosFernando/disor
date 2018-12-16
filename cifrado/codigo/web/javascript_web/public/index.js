// index.js
var m = require("mithril");


const Texto_plano = require("./modulos/Texto_plano.js");
var texto_plano = new Texto_plano("");

const Alfabeto_ingles = require("./modulos/Alfabeto_ingles.js");
var alfabeto_ingles = new Alfabeto_ingles();

const Cifrado_cesar = require("./modulos/Cifrado_cesar.js");
var cifrado_cesar = new Cifrado_cesar(alfabeto_ingles);

const Cifrado_inverso = require("./modulos/Cifrado_inverso.js");
var cifrado_inverso = new Cifrado_inverso();

const Cifrado_grupos = require("./modulos/Cifrado_grupos.js");
var grupos_aux = new Texto_plano("");
var cifrado_grupos = new Cifrado_grupos(grupos_aux,cifrado_inverso);

var body = document.body;

//m(elemento,class,nombre)
//var contendor_principal = m("div",{class:"container"});

var cesar = m("div",{class:"form-group"},[
    m("label","Desplzamiento"),
    m("input",{class:"form-control",id:"desplazamiento"}),
    m("label","Texto"),
    m("textarea",{class:"form-control",id:"texto"}),
    m("label","Texto Cifrado"),
    m("textarea",{class:"form-control",id:"texto_cifrado"})
]);

var inverso = m("div",{class:"form-group"},[
    m("label","Cifrado Inverso"),
    m("textarea",{class:"form-control",id:"texto_inverso"})
]);

var grupos = m("div",{class:"form-group"},[
    m("label","Tamano Grupos"),
    m("input",{class:"form-control",id:"tamano_grupos"}),
    m("label","Texto Cifrado en Grupos"),
    m("textarea",{class:"form-control",id:"texto_grupos"})
]);



//m.mount(contendor_principal,cesar);



m.render(body,[cesar,inverso,grupos]);


document.getElementById("texto").addEventListener("keyup",function(e){
    if(e.keyCode!==8){

    texto_plano.agregar_elemento(e.key);
    var desplazamiento = parseInt(document.getElementById("desplazamiento").value);
    document.getElementById("texto_cifrado").value = cifrado_cesar.cifrar_texto(texto_plano,desplazamiento,0,"");
    document.getElementById("texto_inverso").value = cifrado_inverso.cifrar_texto(texto_plano);
    var tam_grupos = parseInt(document.getElementById("tamano_grupos").value);
    document.getElementById("texto_grupos").value = cifrado_grupos.cifrar_texto(texto_plano,tam_grupos);
    }

    else{
        texto_plano.eliminar_ultimo_elemento();
        document.getElementById("texto_cifrado").value = document.getElementById("texto_cifrado").value.substring(0,document.getElementById("texto_cifrado").value.length-1);
    }
    });