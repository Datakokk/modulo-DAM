package accesoFicherosEjercicios;

import java.io.File;
import java.io.FileReader;
import java.io.IOException;

/**
 * @param arg
 * @throws IOException
 */

public class LeerFicheroEjer {
	
	static String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicherosEjercicios\\";

	public static void main(String[] args) throws IOException{
		// TODO Auto-generated method stub
		File fichero = new File(path + "numeros.txt");
		FileReader fichRea = new FileReader(fichero);
		int i;
		
		while((i=fichRea.read())!= -1) {
			char currentChar = (char)i;
			
			// Filtrar los espacios y las comas
			if(currentChar != ',') {
				System.out.println(currentChar);
			}
			fichRea.close();
		}	
		
	}

}
