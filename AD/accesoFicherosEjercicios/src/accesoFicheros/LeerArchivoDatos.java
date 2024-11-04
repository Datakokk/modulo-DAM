package accesoFicheros;

import java.io.*;

public class LeerArchivoDatos {

	public LeerArchivoDatos() {
		// TODO Auto-generated constructor stub
	}

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		File fichero = new File("C:\\AD\\datos.txt");
		FileInputStream filein = new FileInputStream(fichero);
		DataInputStream dataIS = new DataInputStream(filein);
				
		String n;
		int e;
		
		try {
			while (true) {
				n = dataIS.readUTF();
				e = dataIS.readInt();
				System.out.println("Nombre: "+n+" Edad: "+e);
			}
		}
		catch (EOFException eo) {}
		dataIS.close();
	}

}
