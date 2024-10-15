package accesoFicheros;

import java.io.*;

public class EscribirObjeto {
	static String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicheros\\";
	public EscribirObjeto() {
		
	}
	
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		Persona persona;
		File fichero = new File(path + "FichPersona.txt" );
		FileOutputStream fileout = new FileOutputStream(fichero);
		
		ObjectOutputStream dataOS = new ObjectOutputStream(fileout);
		String nombres[] = {"Vibeke", "Anne", "Anita", "Else"};
		int edades[] = {23, 25, 34, 22};
		
		for(int i=0; i<edades.length; i++) {
			persona = new Persona(nombres[i], edades[i]);
			dataOS.writeObject(persona);
		}
		dataOS.close();
	}

}
