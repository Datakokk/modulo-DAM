package accesoFicheros;

import java.io.*;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
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
    public static void main(String[] args) throws EOFEXception, FileNotFoundException {
        Scanner scanner = new Scanner(System.in);
        // RandomAccessFile file = null;
		FileInputStream fileIN = null; 
		DataInputStream dataIN = null; 

        while (true) {
            System.out.println("Nombre del archivo de origen:");
            String nombreArchivo = scanner.nextLine();

            // Abrimos el archivo de lectura de datos
            File fichero = new File(nombreArchivo);
        	fileIN = new FileInputStream(fichero);
            dataIN = new DataInputStream(fileIN);
//            	file = new RandomAccessFile(fichero, "r"); // Asignamos a 'file'
			System.out.println("Abierto el archivo");
			break;
        }

        // Formato del registro
        int nombre[] = new int[24];
        int telefono[] = new int[9];

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

        // Lectura del archivo
        try {
            while (true) {
                for (int i = 0; i < nombre.length; i++)
                    nombre[i] = dataIN.read(); // Leemos el nombre
                for (int i = 0; i < telefono.length; i++)
                    telefono[i] = dataIN.read(); // Leemos el teléfono

                String nombreS = new String(nombre.toString());
                String telefonoS = new String(telefono.toString());
                System.out.println("Leído NOMBRE: " + nombreS + " - TELÉFONO: " + telefonoS);
//                posicion = posicion + nombre.length + telefono.length + 2;

                Element raiz = documento.createElement("abonado");
                documento.getDocumentElement().appendChild(raiz);
                CrearElemento("nombre", nombreS.trim(), raiz, documento);
                CrearElemento("telefono", telefonoS.trim(), raiz, documento);
            }
        } catch (EOFException e) {
            System.err.println("Alcanzado el final del archivo: " + e.getMessage());
        }
        try { 
        	dataIN.close();
        }
        catch (IOException e)
        {
        	System.out.println("Error al cerrar el archivo")
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

