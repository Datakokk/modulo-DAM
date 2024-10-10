package accesoFicheros;
import java.io.*;

public class escribirFichero {

	static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\";
	public static void main(String[] args) throws IOException{
		// TODO Auto-generated method stub
		File fichero = new File(path + "datosGrabados.txt");
		FileWriter fichWri = new FileWriter(fichero);
		String cadenaGrabada = "Vamos a escribir convirtiendo el string en un array de caracteres";
		//fichWri.write(cadenaGrabada);  // Version con String
		
		char[] cad = cadenaGrabada.toCharArray();
		for(int i=0; i<cad.length; i++) 
			fichWri.write(cad[i]);
		
		fichWri.append("*");
		fichWri.close();
		
	}

}
