package accesoFicheros;

import java.io.*;

public class EscribirDatos {
	static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";

	public static void main(String[] args) throws FileNotFoundException, IOException {
		// TODO Auto-generated method stub
		File fichero = new File(path+"DatosGrabados.txt"); 
		FileOutputStream fileout = new FileOutputStream(fichero);
		DataOutputStream dataOS = new DataOutputStream(fileout);
		String nombres[]= {"Pedro", "Carmen", "Lola", "Andrés"};
		int edades[] = {15,18,23,45};
		try {
			for (int i=0; i<nombres.length; i++) {
				dataOS.writeUTF(nombres[i]);
				dataOS.writeInt(edades[i]);
			}
		}
		catch (FileNotFoundException ex)
		{	
			System.out.println("Error de E/S");
		}	
		
		dataOS.close();
	}

}
