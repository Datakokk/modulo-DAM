package accesoFicheros;
import java.io.*;

public class LeerLineaALinea {
	static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
	public static void main(String[] args) {
		// TODO Auto-generated method stub
	try {
		BufferedReader fichero = new BufferedReader(
				new FileReader(path+"LeerLineaALinea.java"));
		String linea;
		while ((linea=fichero.readLine())!=null)
				System.out.println(linea);
		fichero.close();
	}
	catch (FileNotFoundException fn) {
		System.out.println("No se encuentra el archivo"); }
	catch (IOException io) {
			System.out.println("Error de E/S");}
	}
}
