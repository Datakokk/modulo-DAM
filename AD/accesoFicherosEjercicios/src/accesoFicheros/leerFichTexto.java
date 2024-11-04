package accesoFicheros;
import java.io.*;

public class leerFichTexto {
	//static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
	/**
	 * @param args
	 * @throws IOException
	 */
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		File fichero = new File("datos.txt");
		FileReader fich = new FileReader(fichero);
		int i;
//		while ((i=fich.read()) != -1)
//		{
//			if (i==10 || i==13 )
//				continue;
//			System.out.println((char) i);  //Versión con lectura carácter a carácter
//		}
		char b[]=new char[30]; 			   //Versión con lectura por buffer
		while ((i=fich.read(b)) != -1)
			System.out.println(b);
		fich.close();
	}

}
