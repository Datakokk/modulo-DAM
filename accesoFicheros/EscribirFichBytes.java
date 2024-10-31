package accesoFicheros;

import java.io.*;

public class EscribirFichBytes {
	
	static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		File fichero = new File(path+"FicheroBinario.dat");
		// Creamos el flujo de salida
		FileOutputStream fileout = new FileOutputStream(fichero);
		// Creamos el flujo de entrada
		FileInputStream filein = new FileInputStream(fichero);
		
		int i;
		
		for (i=0; i<100; i++)
			fileout.write(i);
		fileout.close();
		
		// Ver los datos que hemos grabado
		while ((i = filein.read()) != -1)
			System.out.println(i);
		filein.close();
	}

}
