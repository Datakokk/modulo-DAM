package accesoFicheros;

import java.io.*;

import com.thoughtworks.xstream.XStream;

public class LeerXML {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String path = "";
		XStream xstream = new XStream();
		
		xstream.alias("ListaPersonaMunicipio",  ListaPersonas.class);
		xstream.alias("DatosPersona", Persona.class);
		xstream.addImplicitCollection(ListaPersonas.class, "lista");
		
		File fichero = new File("Personas.xml");
		System.out.println(fichero.getAbsolutePath());
		
	
		 
	}

}
