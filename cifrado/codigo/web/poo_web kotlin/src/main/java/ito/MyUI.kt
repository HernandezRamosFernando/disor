package ito

import javax.servlet.annotation.WebServlet

import com.vaadin.annotations.Theme
import com.vaadin.annotations.VaadinServletConfiguration
import com.vaadin.data.HasValue
import com.vaadin.server.VaadinRequest
import com.vaadin.server.VaadinServlet
import com.vaadin.ui.*
import Texto_plano.Texto_plano;
import Alfabeto_ingles.Alfabeto_ingles;
import Cifrados.*;


//clases

/**
 * This UI is the application entry point. A UI may either represent a browser window
 * (or tab) or some part of an HTML page where a Vaadin application is embedded.
 *
 *
 * The UI is initialized using [.init]. This method is intended to be
 * overridden to add component to the user interface and initialize non-component functionality.
 */
@Theme("mytheme")
class MyUI : UI() {
    private var texto_plano = Texto_plano("");
    private var alfabeto_ingles = Alfabeto_ingles();
    private var cifrado_cesar = Cifrado_cesar(alfabeto_ingles,0);
    private var cifrado_inverso = Cifrado_inverso();
    private var  cifrado_grupos_inverso = Cifrado_grupos_inverso(0);
    override fun init(vaadinRequest: VaadinRequest) {
        val layout = VerticalLayout()

        val desplazamiento = TextField()
        val texto = TextArea()
        val texto_cifrado = TextArea()

        val texto_inverso = TextArea()

        val grupo = TextField();
        val texto_grupo = TextArea()




        texto.addValueChangeListener {
            texto_plano.agregar_texto(texto.value);
            cifrado_cesar.modificar_desplazamiento(Integer.parseInt(desplazamiento.value))
            texto_cifrado.value = cifrado_cesar.cifrar_texto(texto_plano).obtener_texto();
            texto_inverso.value = cifrado_inverso.cifrar_texto(texto_plano).obtener_texto();

            cifrado_grupos_inverso.cambiar_grupo(Integer.parseInt( grupo.value))
            texto_grupo.value = cifrado_grupos_inverso.cifrar_texto(texto_plano).obtener_texto()
        }


        //Button button = new Button("Click Me");
        //button.addClickListener(e -> {
        //layout.addComponent(new Label("Thanks " + name.getValue()
        //          + ", it works!"));
        //});

        layout.addComponents(Label("Desplazamiento"), desplazamiento,
                Label("Texto"), texto,
                Label("Texto Cifrado"), texto_cifrado,
                Label("Cifrado Inverso"), texto_inverso,
                Label("grupo"),grupo,
                Label("texto cifrado"),texto_grupo)

        content = layout


    }


    @WebServlet(urlPatterns = arrayOf("/*"), name = "MyUIServlet", asyncSupported = true)
    @VaadinServletConfiguration(ui = MyUI::class, productionMode = false)
    class MyUIServlet : VaadinServlet()
}
