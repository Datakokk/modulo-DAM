package accesoFicheros;
import java.io.*;

public class LeerObjetos {

	public LeerObjetos() {
		// TODO Auto-generated constructor stub
	}

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Persona persona;

		File fichero = new File("FichPersona.txt");
		FileInputStream filein = new FileInputStream(fichero);
		ObjectInputStream dataIS = new ObjectInputStream(filein);

		try {
			// Vamos leyendo objetos del archivo
			while(true) {
				persona = (Persona) dataIS.readObject();  // Leemos un objeto de dataIS
				System.out.println("Hemos leído el objeto Nombre: "+
				persona.getNombre()+" Edad: "+persona.getEdad());
			}
		}
		catch (EOFException eo)
		{
			System.out.println("Leídos todos los objetos del archivo");
		}
		catch (FileNotFoundException eo)
		{
			System.out.println("No se encuentra el archivo");
		}
		catch (ClassNotFoundException cn) {
			System.out.println("Clase no encontrada");
		}
	
		dataIS.close();
	}

}
