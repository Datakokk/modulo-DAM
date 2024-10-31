package accesoFicheros;
import java.io.*;

public class EscribirLineaALinea {
	static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
	public static void main(String[] args) {
		// TODO Auto-generated method stub
	try {
		PrintWriter fichero = new PrintWriter(
//		BufferedWriter fichero = new BufferedWriter(
				new FileWriter(path+"DatosLineaALinea.txt"));
		for (int i=0; i<11; i++) {
			fichero.println("Fila número "+i);
//			fichero.write("Fila número "+i);
//			fichero.newLine();
		}
		fichero.close();
	}
	catch (FileNotFoundException fn) {
		System.out.println("No se encuentra el archivo"); }
	catch (IOException io) {
			System.out.println("Error de E/S");}
	}
}
