package accesoFicheros;

import java.io.*;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import com.thoughtworks.xstream.XStream;

public class LeerXML {
	public static void main(String[] args) {
		String path="C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\";
		File fichero = new File("Personas.xml");

		XStream xstream = new XStream();
		
		xstream.alias("ListaPersonasMunicipio", ListaPersonas.class);
		xstream.alias("DatosPersona", Persona.class);
		xstream.addImplicitCollection(ListaPersonas.class, "lista");
		
		System.out.println(fichero.getAbsolutePath());
		FileInputStream fich= new FileInputStream(fichero);
		ListaPersonas listadoTotal = (ListaPersonas) xstream.fromXML(fich);

	
//		System.out.println("Número de personas: "+listadoTotal.getListaPersonas().size());
//		
//		List<Persona> listaPersonas = new ArrayList<Persona>();
/*		listaPersonas = listadoTotal.getListaPersonas();
		
		Iterator iterador = listaPersonas.listIterator();
		
		while ( iterador.hasNext() ) {
			Persona p = (Persona) iterador.next();
			System.out.println ("Nombre: "+ p.getNombre()+ ", Edad: "+p.getEdad() );
		}
		System.out.println("----Fin del listado----");
*/	}
}
