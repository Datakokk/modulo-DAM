package accesoFicheros;
import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;

import com.thoughtworks.xstream.XStream;

public class CrearXML {

    public static void main(String[] args) throws IOException, ClassNotFoundException {
        File fichero = new File("C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicheros\\FichPersona.txt");
        FileInputStream filein = new FileInputStream(fichero);
        
        ObjectInputStream dataIS = new ObjectInputStream(filein);
        System.out.println("Iniciando importación a XML");
        
        ListaPersonas listaper = new ListaPersonas();
        
        try {
            while (true) {
                try {
                    Persona persona = (Persona) dataIS.readObject();
                    listaper.add(persona);
                } catch (EOFException eof) {
                    // Fin del archivo, salir del ciclo
                    break;
                }
            }
        } catch (IOException ioe) {
            ioe.printStackTrace();
        } finally {
            dataIS.close(); // Asegurarse de cerrar el stream
        }
        
        try {
            XStream xstream = new XStream();
            xstream.alias("ListaPersonasMunicipio", ListaPersonas.class);
            xstream.alias("DatosPersona", Persona.class);
            
            xstream.addImplicitCollection(ListaPersonas.class, "lista");
            xstream.toXML(listaper, new FileOutputStream("Personas.xml"));
            System.out.println("Creado fichero .XML");
        } catch (IOException ioe) {
            ioe.printStackTrace();
        }
    }

}
