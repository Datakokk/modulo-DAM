package accesoFicheros;

import java.io.*;

public class leerFichTexto {

	public static void main(String[] args)  throws IOException{
		// TODO Auto-generated method stub
		 File fichero = new File("C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\notas.txt");
		FileReader fich = new FileReader(fichero);
		int i;
		char b[] = new char[20];
		while((i=fich.read(b)) != -1) {//Version con lectura por buffer
			System.out.println(b);
		}
		/**
		 * while((i=fich.read()) != -1)
		 * 	System.out.print((char) i) // Version de lectura carácter a carácter
		 */
		// Cerrar fichero
		fich.close();
	}

}
