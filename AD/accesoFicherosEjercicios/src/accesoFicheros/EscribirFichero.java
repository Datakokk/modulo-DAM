package accesoFicheros;
import java.io.*;

public class EscribirFichero {
	static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		File fichero = new File(path+"datosGrabados.txt");
		FileWriter fich = new FileWriter(fichero);
		String cadenaGrabada = "Alumno: Carlos Calvo, 2-DAM";
//		fich.write(cadenaGrabada);  // Versión con String
		char[] cad = cadenaGrabada.toCharArray();
		for (int i=0; i<cad.length; i++)
			fich.write(cad[i]);
		fich.append("*");
		fich.close();
	}

}
