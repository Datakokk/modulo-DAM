package accesoFicheros;
import java.io.*;
import com.thoughtworks.xstream.XStream;

public class CrearXML {

	public static void main(String[] args) throws IOException, ClassNotFoundException {
		// TODO Auto-generated method stub
		File fichero = new File("FichPersona.txt");
		FileInputStream filein = new FileInputStream(fichero);
		
		ObjectInputStream dataIS = new ObjectInputStream(filein);
		System.out.println("Iniciando importación a XML");
		
		ListaPersonas listaper = new ListaPersonas();
				
		try {
			while (true) {
				Persona persona = (Persona) dataIS.readObject();
				listaper.add(persona);
			}
		}
		catch (EOFException eo) {eo.printStackTrace();}
		dataIS.close();
		
		try {
			XStream xstream = new XStream();
			xstream.alias("ListaPersonasMunicipio", ListaPersonas.class);
			xstream.alias("DatosPersona", Persona.class);
			
			xstream.addImplicitCollection(ListaPersonas.class, "lista");
			
			xstream.toXML(listaper, new FileOutputStream("Personas.xml"));
			System.out.println("Creado fichero XML");
		}
		catch (Exception e)	{
			e.printStackTrace());
		}
		
		}
	}

}
