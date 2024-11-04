package test;

import java.io.*;

public class LeerFicheroTextoBuf {

	
	public LeerFicheroTextoBuf() {
		
		// TODO Auto-generated constructor stub
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String path = "C:\\AD\\";
		try {
			BufferedReader fichero = new BufferedReader(
					new FileReader(path+"datos.txt"));
			String linea;
			while((linea = fichero.readLine())!=null)
				System.out.println(linea);
			fichero.close();
		}
		catch (FileNotFoundException fn) {
			System.out.println("No se encuentra el archivo");
		}
		catch (IOException io) {
			System.out.println("Error de E/S");
		}
	}

}
