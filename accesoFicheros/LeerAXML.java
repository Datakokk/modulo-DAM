package accesoFicheros;

import org.w3c.dom.*;
import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.*;
import java.io.*;

public class LeerAXML {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		File fichero = new File("Listin.txt");
		// TODO Auto-generated method stub
		RandomAccessFile file = new RandomAccessFile(fichero,"r");
		
		char nombre[] = new char[24];
		char telefono[] = new char[9];
		
		DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
		DocumentBuilder builder = factory.newDocumentBuilder();
		DOMImplementation implementation = builder.getDOMImplementation();
		Document documento = implementation.createDocument(null, "Listín", null);
		documento.setXmlVersion("1.0");
			
	int posicion=0;	
	while(true) {
		try {
			file.seek(posicion);
		}
		catch (EOFException ex) {
			System.out.println("Alcanzado el final del archivo");
			break;
		}
		
		for (int i=0;i<nombre.length;i++) 
			nombre[i]=file.readChar();  // Leemos el nombre
		for (int i=0;i<telefono.length;i++) 
			telefono[i]=file.readChar();  // Leemos el teléfono
		String nombreS=new String(nombre);
		String telefonoS=new String(telefono);
		System.out.println("Leído NOMBRE: "+nombreS+" - TELÉFONO: "+telefonoS);
		posicion=posicion+nombre.length+telefono.length;
//				if (file.getFilePointer()==file.length()) break;

		Element raiz = documento.createElement("abonado");
		documento.getDocumentElement().appendChild(raiz);
		CrearEmpleadoXML.CrearElemento("nombre",nombreS.trim(),raiz,documento);
		CrearEmpleadoXML.CrearElemento("teléfono",telefonoS.trim(),raiz,documento);
	}
	
		file.close();
		Source source = new DOMSource(documento);
//		Result result = new StreamResult(new java.io.File("Empleados.xml"));
		Result result = new StreamResult(System.out); // Lo imprime por consola
	
		try {
			Transformer transformer = TransformerFactory.newInstance().newTransformer();
			transformer.transform(source, result);
		}
		catch ()
	}
}
