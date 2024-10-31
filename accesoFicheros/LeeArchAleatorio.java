package accesoFicheros;
import java.io.*;
import java.util.Scanner;

public class LeeArchAleatorio {

	public static void main(String[] args) throws IOException {
		final String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
		File fichero = new File(path+"AleatorioEmple.txt");
		// TODO Auto-generated method stub
		RandomAccessFile file = new RandomAccessFile(fichero,"r");
		
		int id, dep, posicion;
		Double salario;
		char apellido[] = new char[10];
		
		posicion=0;
		// ID(Int, 4 bytes) - APELLIDO (10 chars) - DEP(Int, 4 bytes) - SALARIO (Double, 8 bytes) 
		while(true) {
			file.seek(posicion);
			id=file.readInt(); // Leemos el id de empleado
			for (int i=0;i<apellido.length;i++) 
				apellido[i]=file.readChar();  // Leemos el apellido
			String apellidoS=new String(apellido);
			dep=file.readInt(); // Leemos el departamento
			salario=file.readDouble(); // Leemos el sueldo (8 bytes)
			System.out.println("ID empleado: "+id+" - Apellido: "+
					apellidoS+" - Depto "+dep+" - Salario: "+salario);
			posicion=posicion+36;
			if (file.getFilePointer()==file.length()) break;
		}
		file.close();
	}
}
