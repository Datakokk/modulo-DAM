package accesoFicheros;

import java.io.*;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.EOFException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.Result;
import javax.xml.transform.Source;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Text;
import javax.xml.parsers.ParserConfigurationException;

public class LeerAXML2 {
    public static void main(String[] args) throws IOException {
        Scanner scanner = new Scanner(System.in);
		FileInputStream fileIN = null; 
		DataInputStream dataIN = null; 
		File fichero = null;
		String nombreArchivo = null;

        while (true) {   // Petición de nombre de archivo de origen
        	try {
	            System.out.print("Nombre del archivo de origen: ");
	            nombreArchivo = scanner.nextLine();
	
	            // Abrimos el archivo de lectura de datos
	            fichero = new File(nombreArchivo);
	        	fileIN = new FileInputStream(fichero);
	            dataIN = new DataInputStream(fileIN);
				System.out.println("Abierto el archivo de origen "+nombreArchivo);
				break;
	        }
        	catch (FileNotFoundException fn)
    		{
        		System.out.println("Archivo "+nombreArchivo+" no encontrado.");
    		}	
		}
		
        // Crear el documento XML
        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
        DocumentBuilder builder = null;
        try {
            builder = factory.newDocumentBuilder(); // Manejar ParserConfigurationException
        } catch (ParserConfigurationException e) {
            System.err.println("Error al crear el DocumentBuilder: " + e.getMessage());
            return; // Salimos si no se puede crear el DocumentBuilder
        }

        DOMImplementation implementation = builder.getDOMImplementation();
        Document documento = implementation.createDocument(null, "Listín", null);
        documento.setXmlVersion("1.0");

        // Formato del registro
        StringBuilder cadenaNombre=new StringBuilder(24);
        StringBuilder cadenaTelefono=new StringBuilder(9);
        		
        // Lectura del archivo
        try {
            while (true) {
                for (int i = 0; i < cadenaNombre.capacity(); i++) {
                    //nombre[i] = dataIN.readByte(); // Leemos el nombre
                	
//                    String letraLeida=new String(Character.toChars(dataIN.readByte()));
                    String letraLeida=new String(dataIN.readUTF().getBytes("UTF-8"),"ISO-8859-1");
                    
                	cadenaNombre.setCharAt(i,letraLeida.toCharArray()[1]);
                    System.out.println("Leídos los caracteres: " + cadenaNombre.toString());
                }   
                for (int i = 0; i < cadenaTelefono.capacity(); i++) {
                    //String numeroLeido=new String(Character.toChars(dataIN.readByte()));
                	String numeroLeido=new String(dataIN.readUTF().getBytes("UTF-8"),"ISO-8859-1");
                    cadenaTelefono.setCharAt(i,numeroLeido.toCharArray()[1]);
                    System.out.println("Leídos los caracteres: " + cadenaTelefono.toString());
                }
                dataIN.readByte(); // Salto de línea
                String nombreS = new String(cadenaNombre.toString());
                String telefonoS = new String(cadenaTelefono.toString());
                System.out.println("Leído NOMBRE: " + nombreS + " - TELÉFONO: " + telefonoS );
//                posicion = posicion + nombre.length + telefono.length + 2;

                Element raiz = documento.createElement("abonado");
                documento.getDocumentElement().appendChild(raiz);
                CrearElemento("nombre", nombreS.trim(), raiz, documento);
                CrearElemento("telefono", telefonoS.trim(), raiz, documento);
                cadenaNombre.setLength(0);
                cadenaTelefono.setLength(0);
            }
        } catch (EOFException e) {
            System.err.println("Alcanzado el final del archivo: ");
        }
        try { 
        	dataIN.close();
        }
        catch (IOException e)
        {
        	System.out.println("Error al cerrar el archivo");
        }
 
        // Transformación y salida del XML
        Source source = new DOMSource(documento);
        Result result = new StreamResult(System.out);
        try {
            Transformer transformer = TransformerFactory.newInstance().newTransformer();
            transformer.transform(source, result);
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
        }
    }

    private static void CrearElemento(String datoEmple, String valor, Element raiz, Document document) {
        Element elem = document.createElement(datoEmple);
        Text text = document.createTextNode(valor);
        raiz.appendChild(elem);
        elem.appendChild(text);
        System.out.println("Creado el elemento " + datoEmple + "/> con contenido " + text);
    }
}

