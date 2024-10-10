package accesoFicheros;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.*;

public class EscrituraLineaALinea {

	static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\";
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try {
			BufferedWriter fichero = new BufferedWriter(
				new FileWriter(path + "DatosLineaALinea.txt"));
			
			for(int i=0; i<11; i++) {
				fichero.write("Fila numero " +i);
				fichero.newLine();
			}
			fichero.close();
			
		}catch(FileNotFoundException fn) {
			System.out.println("No se encuentra el archivo");
		}catch(IOException io) {
			System.out.println("Error de E/S");
		}
	}

}
