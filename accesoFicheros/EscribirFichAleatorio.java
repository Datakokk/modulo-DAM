package accesoFicheros;
import java.io.*;

public class EscribirFichAleatorio {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		static String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\"; 
		File fichero=new File(path+"AleatorioEmple.txt");
		RandomAccessFile file = new RandomAccessFile(fichero,"rw");

		String apellido[]= {"FERNANDEZ","PEREZ","GIL","SANTOS","JIMENO"};
		int dep[] = {10, 20, 30, 10,20};
		Double salario[] = {1000.45, 1545.10, 2000.43, 1870.20,2345.3};
		
		StringBuffer buffer = null;
		for (int i=0;i<apellido.length;i++) {
			file.writeInt(i+1);
			buffer=new StringBuffer(apellido[i]);
			buffer.setLength(10);  // 10 chars para el apellido.
			file.writeChars(buffer.toString());
			file.writeInt(dep[i]);
			file.writeDouble(salario[i]);
		}
		System.out.println("Contenido creado");
		file.close();
	}
}
