package accesoFicheros;

import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.Scanner;

import org.w3c.dom.Document;
import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Element;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

public class LeerAXML {

    public static void main(String[] args) throws IOException, ParserConfigurationException, TransformerException {
        // Lectura del nombre del archivo de origen
        System.out.println("Nombre del archivo de origen:");
        Scanner scanner = new Scanner(System.in);
        String nombreArchivo = scanner.nextLine();
        scanner.close();

        // Abrimos el archivo de lectura aleatoria
        File fichero = new File(nombreArchivo);
        RandomAccessFile file = new RandomAccessFile(fichero, "r");
        System.out.println("Abierto el fichero");

        // Formato del registro
        char nombre[] = new char[24];
        char telefono[] = new char[9];

        // Configuración del documento XML
        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
        DocumentBuilder builder = factory.newDocumentBuilder();
        DOMImplementation implementation = builder.getDOMImplementation();
        Document documento = (Document) implementation.createDocument(null, "Abonados", null);
        documento.setXmlVersion("1.0");

        // Lectura del fichero
        int posicion = 0;
        while (true) {
            try {
                file.seek(posicion);

                for (int i = 0; i < nombre.length; i++) {
                    nombre[i] = file.readChar(); // leemos el nombre
                }
                for (int i = 0; i < telefono.length; i++) {
                    telefono[i] = file.readChar(); // leemos el telefono
                }
                String nombreS = new String(nombre).trim();
                String telefonoS = new String(telefono).trim();
                System.out.println("Nombre: " + nombreS + " - Telefono: " + telefonoS);

                // Crear y agregar el elemento abonado
                Element raiz = documento.createElement("abonado");
                documento.getDocumentElement().appendChild(raiz);

                // Llamada para crear y agregar los elementos al abonado
                CrearElemento("nombre", nombreS, raiz, documento);
                CrearElemento("telefono", telefonoS, raiz, documento);

                posicion += (nombre.length + telefono.length + 2) * 2; // Mover la posición en el archivo

                // Verificar si se alcanzó el final del archivo
                if (file.getFilePointer() == file.length()) {
                    System.out.println("Alcanzado el final del archivo");
                    break;
                }

            } catch (IOException ioe) {
                ioe.printStackTrace();
            }
        }
        
        file.close();

        // Guardar el documento XML en un archivo
        TransformerFactory transformerFactory = TransformerFactory.newInstance();
        Transformer transformer = transformerFactory.newTransformer();
        DOMSource source = new DOMSource(documento);
        StreamResult result = new StreamResult(new File("Abonados.xml"));
        transformer.transform(source, result);

        System.out.println("Archivo XML creado exitosamente.");
    }

    // Método para crear un nuevo elemento y añadirlo al nodo raíz
    public static void CrearElemento(String etiqueta, String valor, Element raiz, Document documento) {
        Element elem = documento.createElement(etiqueta);
        elem.appendChild(documento.createTextNode(valor));
        raiz.appendChild(elem);
    }
}
