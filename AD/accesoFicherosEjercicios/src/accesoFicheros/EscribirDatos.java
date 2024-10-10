package accesoFicheros;
import java.io.*;

public class EscribirDatos {

	static String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicherosEjercicios\\";
	
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		
		FileOutputStream fileout = new FileOutputStream(path + "DatosGrabados.txt");
		DataOutputStream fileOS = new DataOutputStream(fileout);
		
		String nombres[] = {"Anita", "Brigitte", "Vibeke", "Solvi"};
		int edades[] = {28, 27, 22, 24};
		
		for(int i=0; i<nombres.length; i++) {
			fileOS.writeUTF(nombres[i]);
			fileOS.writeInt(edades[i]);
		}
		fileOS.close();
	}

}
