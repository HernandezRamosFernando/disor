import javax.swing.*;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class gui {
    private JTextField desplazamiento;
    private JTextField texto;
    private JTextField texto_cifrado;
    private JTextField texto_inverso;
    private JTextField grupo;
    private JTextField texto_grupo;
    public JPanel panel1;

    public gui() {
        texto.addKeyListener(new KeyAdapter() {
            @Override
            public void keyReleased(KeyEvent e) {
                if(e.getKeyCode()!=8){
                    MainKt.getTexto_plano().agregar_caracter(e.getKeyChar());

                    MainKt.getCifrado_cesar().modificar_desplazamiento(Integer.parseInt(desplazamiento.getText()));
                    texto_cifrado.setText(MainKt.getCifrado_cesar().cifrar_texto(MainKt.getTexto_plano()).obtener_texto());

                    texto_inverso.setText(MainKt.getCifrado_inverso().cifrar_texto(MainKt.getTexto_plano()).obtener_texto());

                    MainKt.getCifrado_grupos_inverso().cambiar_grupo(Integer.parseInt(grupo.getText()));
                    texto_grupo.setText(MainKt.getCifrado_grupos_inverso().cifrar_texto(MainKt.getTexto_plano()).obtener_texto());
                }

                else{
                    MainKt.getTexto_plano().eliminar_ultimo_caracter();
                }
            }
        });
    }
}
