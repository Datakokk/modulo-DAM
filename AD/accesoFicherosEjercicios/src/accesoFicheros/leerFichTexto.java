package accesoFicheros;
import java.io.*;

public class LeerFichTexto {
	//static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
	/**
	 * @param args
	 * @throws IOException
	 */
	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		try {
		    File fichero = new File("C:\\ruta\\completa\\datos.txt");
		    FileReader fich = new FileReader(fichero);
		    char b[] = new char[30];
		    int i;
		    while ((i = fich.read(b)) != -1) {
		        System.out.print(new String(b, 0, i)); // Solo imprime los caracteres leídos
		    }
		    fich.close();
		} catch (FileNotFoundException e) {
		    System.out.println("El archivo no fue encontrado.");
		} catch (IOException e) {
		    System.out.println("Ocurrió un error al leer el archivo.");
		}

	}

}
