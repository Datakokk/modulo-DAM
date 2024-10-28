package accesoFicheros;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.ObjectInputStream;

public class LeerObjetos {

	static String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicheros\\";
	public LeerObjetos() {
		
	}
	
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Persona persona;
		File fichero = new File(path + "FichPersona.txt");
		FileInputStream filein = new FileInputStream(fichero);
		
		ObjectInputStream dataIs = new ObjectInputStream(filein);
		
		try {
			// vamos leyendo objeto del archivo
			while(true) {
				persona = (Persona) dataIs.readObject();// Leemos un objeto de dataIS
				System.out.println("Hemos leido el objeto Nombre: " + persona.getNombre() + ", Edad: " + persona.getEdad() + " años");
			}
		}
		catch(IOException eo) {
			System.out.println("Leidos todos los objetos del archivo");
		}
		catch (ClassNotFoundException cn) {
			// TODO: handle exception
			System.out.println("Clase no encontrada");
		}
		dataIs.close();
	}

}
