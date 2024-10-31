package accesoFicheros;
import java.io.*;

public class EscribirObjeto {

	// static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Persona persona;
		
		File fichero = new File("FichPersona.txt");
		FileOutputStream fileout = new FileOutputStream(fichero);
		ObjectOutputStream dataOS = new ObjectOutputStream(fileout);
		
		String nombres[] = {"Manuel", "César", "Luisa", "Mila"};
		int edades[] = {59, 71, 45, 62}; 
		
		for (int i=0; i<edades.length; i++) {
			persona = new Persona(nombres[i], edades[i]);
			dataOS.writeObject(persona);
			System.out.println("Grabado el objeto "+persona.getNombre());
		}
		dataOS.close();
	}

}
