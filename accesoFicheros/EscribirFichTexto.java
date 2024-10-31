package test;
import java.io.*;

public class EscribirFichTexto {


	public EscribirFichTexto() {
		// TODO Auto-generated constructor stub

	}

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		String path = "C:\\AD\\"; 
		File fichero = new File(path+"datos.txt");
		FileWriter fic = new FileWriter(fichero);
		String cadena = "Esto es lo que voy a grabar";
		char[] cad = cadena.toCharArray();
		// for (int i=0; i<cad.length; i++)
		fic.write(cad);
		fic.append("*");
		fic.close();
	}

}
