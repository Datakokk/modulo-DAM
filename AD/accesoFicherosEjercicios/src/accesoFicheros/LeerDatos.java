package accesoFicheros;

import java.io.DataInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;

public class LeerDatos {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		File fichero = new File("C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicherosEjercicios\\DatosGrabados.txt");
		FileInputStream fileIn = new FileInputStream(fichero);
		DataInputStream dataIS = new DataInputStream(fileIn);
		
		String nombre;
		int edad;
		
		try {
			while(true) {
				nombre = dataIS.readUTF();
				edad = dataIS.readInt();
				System.out.println("Name: " + nombre + "   age: "+ edad);
			}
		}
		catch(IOException io) {
			System.out.println("Alcanzado el final del archivo");
		}
		
		dataIS.close();
	}

}
