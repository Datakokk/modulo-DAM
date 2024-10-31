package test;
import java.io.*;

public class EscribirArchivoDatos {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		File fichero = new File("C:\\AD\\datos.txt");
		FileOutputStream fileout = new FileOutputStream(fichero);
		DataOutputStream dataOS = new DataOutputStream(fileout);
		
		String nombres[]= {"Manuel","César","Daniel","Mila"};
		int edades[]= {59,71,80,62};
		
		for(int i=0;i<nombres.length;i++) {
			dataOS.writeUTF(nombres[i]);
			dataOS.writeInt(edades[i]);
		}
		dataOS.close();
	}

}
