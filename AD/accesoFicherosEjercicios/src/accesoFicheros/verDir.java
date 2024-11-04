package accesoFicheros;
import java.io.*;

public class verDir {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("Ficheros del directorio actual");
		File f = new File("NUEVODIR");
		String[] archivos = f.list();
		for (int i=0; i <archivos.length; i++)
			System.out.println(archivos[i]);
	}
}
