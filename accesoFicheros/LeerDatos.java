package accesoFicheros;

import java.io.*;

public class LeerDatos {
	static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";

	public static void main(String[] args) throws FileNotFoundException, IOException {
		// TODO Auto-generated method stub
//		File fichero = new File(path+"DatosGrabados.txt"); 
		FileInputStream filein = new FileInputStream(path+"DatosGrabados.txt");
		DataInputStream dataIN = new DataInputStream(filein);
		String cadenaLeida;
		int enteroLeido;
		try {
			while(true) {
				cadenaLeida=dataIN.readUTF();
				enteroLeido=dataIN.readInt();
				System.out.println("Leída la cadena "+cadenaLeida+
						" y el entero "+enteroLeido);
			}
		}
		catch (EOFException eo){
			System.out.println("Alcanzado el final del archivo");
		}
		
		dataIN.close();
	}

}