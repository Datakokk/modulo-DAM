package accesoFicheros;
import java.io.*;
import java.util.InputMismatchException;
import java.util.Scanner;

public class LeerElementosDeFicheroAleatorio {

	public static void main(String[] args) throws FileNotFoundException {
		// TODO Auto-generated method stub
		String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicheros\\";
		File fichero = new File(path+"AleatorioEmple.txt");
		RandomAccessFile file = new RandomAccessFile(fichero,"r");
		Scanner in=new Scanner(System.in);
		int id;
				
				
				
	   while(true){
		   try {
			   System.out.println("Indica el número de empleado que deseas ver: ");
			   id=in.nextInt();
			   
			   int dep, posicion;
			   Double salario;
			   char apellido[] = new char[10];
			   
			   posicion=(id-1)*36;
			   
			   file.seek(posicion);
			   id=file.readInt();
			   for (int i=0;i<apellido.length;i++)
				   apellido[i]=file.readChar();
			   String apellidoS=new String(apellido);
			   dep=file.readInt();
			   salario=file.readDouble();
			   System.out.println("ID empleado: "+id+"- Apellido: "+apellidoS+"- Depto "+dep +" - Salario: "+salario);
			   System.out.println();
		   }
		   catch(InputMismatchException ex)
		   {
			   System.out.println("Eso no es un número de empleado. ");//InputMismatchException
			   in.next();
		   }
		   catch(EOFException ex2)
		   {
			   System.out.println("No existe ese número de empleado. ");
		   }
		   catch(IOException ex3)
		   {
			   System.out.println("No existe ese archivo.");
		   }
	   }
	}

}
