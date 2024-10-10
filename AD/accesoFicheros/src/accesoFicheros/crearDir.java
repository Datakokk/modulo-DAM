package accesoFicheros;

import java.io.*;

public class crearDir {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		File d = new File("NUEVODIR");
		File f1 = new File("FICHERO1.txt");
		File f2 = new File("FICHERO2.txt");
		
		d.mkdir(); // Create folder
		
		try {
			if(f1.createNewFile()) {
				System.out.println("Creado el nuevo archivo 1");
			}
			else {
				System.out.println("No se ha podido crear el nuevo archivo 1");
			}
			
			if(f2.createNewFile()) {
				System.out.println("Creado el nuevo archivo 2");
			}
			else {
				System.out.println("No se ha podido crear el nuevo archivo2");
			}
		}catch(IOException ioe) {
			ioe.printStackTrace();
		}
		
		f1.renameTo(new File(d, "NUEVOARCHIVO1"));
		
		try {
			// Crear un nuevo archivo en el directorio NUEVODIR
            File f3 = new File(d, "FICHERO3.txt");
            if (f3.createNewFile()) {
                System.out.println("Creado el archivo FICHERO3.txt en NUEVODIR");
            } else {
                System.out.println("No se ha podido crear FICHERO3.txt en NUEVODIR");
            }
		}catch(IOException ioe) {
			ioe.printStackTrace();
		}
	}

}
