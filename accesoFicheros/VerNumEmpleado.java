package accesoFicheros;
import java.io.*;
import java.util.*;

public class NumEmpleadoDeApellido {
	public static void main(String[] args) throws FileNotFoundException, IOException {
		// TODO Auto-generated method stub
		// String path = "C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
		File fichero = new File("AleatorioEmple.txt");
		RandomAccessFile file = new RandomAccessFile(fichero,"r");
		Scanner in=new Scanner(System.in);
		int id;
		
		while(true) {
			try {
				System.out.print("Indica el número del empleado que quieres ver: ");
				id=in.nextInt();  // Hace saltar la excepcion InputMismatchException
				
				int dep, posicion;
				Double salario;
				char apellido[] = new char[10];
				
				posicion=(id-1)*36; // estructura 
				
				file.seek(posicion);
				id=file.readInt();
				for (int i=0;i<apellido.length;i++) 
					apellido[i]=file.readChar();
				String apellidoS=new String(apellido);
				dep=file.readInt();
				salario=file.readDouble();
				System.out.println("ID empleado: "+id+" - Apellido: "+apellidoS
						+" - Depto "+dep+" - Salario: "+salario);
				System.out.println();		
			}
			catch(InputMismatchException ex) //InputMismatchException
			{
				System.out.println("Eso no es un número de empleado. ");
				in.next();
			}
			catch(EOFException ex2) //EOFException. 
									//Se ha intentado leer más allá del final.
			{
				System.out.println("No existe ese número de empleado. ");
			}
			catch(IOException ex3) //IOException
			{
				System.out.println("No existe ese archivo. ");
			}
		}
	}
}