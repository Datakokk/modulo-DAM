package accesoFicheros;

import java.io.*;

import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.*;

import org.w3c.dom.*;

public class CrearEmpleadoXML {

    public static void main(String[] args) throws IOException {
    	
        File fichero = new File("C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicheros\\AleatorioEmple.txt");
        RandomAccessFile file = new RandomAccessFile(fichero, "r");

        int id, dep, posicion = 0;
        Double salario;
        char[] apellido = new char[10];

        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();

        try {
        	
            DocumentBuilder builder = factory.newDocumentBuilder();
            DOMImplementation implementation = builder.getDOMImplementation();

            Document document = implementation.createDocument(null, "Empleados", null);

            document.setXmlVersion("1.0");

            while (true) {
                file.seek(posicion);
                id = file.readInt();

                for (int i = 0; i < apellido.length; i++) {
                    apellido[i] = file.readChar();
                }

                String apellidosS = new String(apellido).trim(); // Eliminar espacios extra

                dep = file.readInt();
                salario = file.readDouble();

                if (id > 0) {
                    // Crear nodo 'empleado' y añadirlo al documento
                    Element raiz = document.createElement("empleado");
                    document.getDocumentElement().appendChild(raiz);

                    // Crear los subelementos para id, apellido, dep y salario
                    CrearElemento("id", Integer.toString(id), raiz, document);
                    CrearElemento("apellido", apellidosS.trim(), raiz, document);
                    CrearElemento("dep", Integer.toString(dep), raiz, document);
                    CrearElemento("salario", Double.toString(salario), raiz, document);
                // Avanzar la posición (36 bytes por registro)
                posicion = posicion + 36;

	                if (file.getFilePointer() == file.length()) {
	                    break; // Salir del bucle si hemos llegado al final del archivo
	                }
                }

            // Crear y guardar el archivo XML
            Source source = new DOMSource(document);
            Result result = new StreamResult(new File("Empleados.xml"));
            Transformer transformer = TransformerFactory.newInstance().newTransformer();
            transformer.transform(source, result);
            }
            System.out.println("Archivo XML generado exitosamente."); 
        }catch (Exception e) {
            System.err.println("Error: " + e);
        } finally {
            file.close(); // Asegurarse de cerrar el archivo
        }
    }

    // Método para crear elementos dentro del documento XML
    static void CrearElemento (String datoEmple, String valor, Element raiz, Document document) {
		Element elem = document.createElement(datoEmple);
		Text text = document.createTextNode(valor);
		raiz.appendChild(elem);
		elem.appendChild(text);
	}
}