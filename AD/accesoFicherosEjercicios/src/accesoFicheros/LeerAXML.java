package accesoFicheros;

import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.lang.annotation.Documented;

public class LeerListinYGrabarXMl {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		File fichero = new File("");
		
		RandomAccessFile file = new RandomAccessFile(fichero, "r");
		
		char nombre[] = new char[24];
		char telefono[] = new char[9];
		
		int posicion = 0;
		
		while(true) {
			file.seek(posicion);
			for(int i=0; i<nombre.length; i++) {
				nombre[i]=file.readChar();
			}
			for(int i=0; i<telefono.length; i++) {
				nombre[i] = file.readChar();
			}
			String nombreS = new String(nombre).trim();
			String telefonoS = new String(telefono).trim();
			System.out.println("Nombre: " + nombreS + " - Telefono: " + telefonoS);
			posicion = posicion + nombre.length + telefono.length;
			
			//if(file.getFilePointer() == file.length()) break;
		
		}
		
	}

}
