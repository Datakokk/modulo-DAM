package accesoFicheros;
import java.io.File;
import java.io.IOException;
import java.io.RandomAccessFile;

public class EscribirFicheroAleatorio {
			
	public static void main(String[] args) throws IOException {
		
		 String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicheros\\";
		// TODO Auto-generated method stub
		File fichero = new File(path + "AleatorioEmple.txt");	
		RandomAccessFile file=new RandomAccessFile(fichero,"rw");//PERMISO DE LECT Y ESCRITURA
		
		String apellido[]= {"FERNANDEZ","PEREZ","GIL","SANTOS","JIMENO"};
		int dep[]= {10,20,30,10,20};
		Double salario[]= {1000.45,1545.10,2000.43,1870.20,2345.3};
		
		//Dos formas:
		
		//1:
		
		StringBuffer buffer=null;
		
		for(int i =0;i<apellido.length;i++) {
			file.writeInt(i+1);
			buffer=new StringBuffer(apellido[i]);
			buffer.setLength(10); // 10 chars para el apellido.
			file.writeChars(buffer.toString());
			file.writeInt(dep[i]);
			file.writeDouble(salario[i]);
		}
		System.out.println("Contenido creado");
		file.close();
	}
}
