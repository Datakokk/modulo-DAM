package accesoFicheros;

import java.io.EOFException;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.InputMismatchException;
import java.util.Scanner;

public class VerNumEmpleado {

	public static void main(String[] args) throws FileNotFoundException {
		// TODO Auto-generated method stub
		// TODO Auto-generated method stub
		String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicheros\\";
		File fichero = new File(path+"AleatorioEmple.txt");
		RandomAccessFile file = new RandomAccessFile(fichero,"r");
		Scanner in=new Scanner(System.in);
		
		 while(true){// Recorremos todo el archibo hasta encontrar un registo cuyo nombre coincida con el introducido
			 try {
				 int id=1;
				 System.out.println("Indica el apellido del empleado que deseas ver: ");
				 String apellidoLeido = in.next();//Lee el stingidtoducido
				 apellidoLeido.trim();
				 int dep, posicion;
				 Double salario;
				 char apellido[] = new char[10];
			   
				 // lectua de registro del archivo
				 posicion = 0;
				 while(true) {
					 posicion=(id-1)*36; // estructura 4int, 10(x2)char, 4 int, 8 double
					 file.seek(posicion+4); //Nos ponemos donde empieza el apellido
					 for (int i=0;i<apellido.length;i++) { //Leemos el apellido
						 apellido[i]=file.readChar(); // caracter a caracter
					 	// System.out.println("Letra leida: " + apellido[i]);
					 }
					 String apellidoEnFichero = "".valueOf(apellido).trim();
					 System.out.println("Apellido leido: "+apellidoLeido);
					 System.out.println("Apellido en disco: "+apellidoEnFichero);

					 if(apellidoLeido.equals(apellidoEnFichero)) {
						 System.out.println("El númeor del empleado " + apellidoLeido.trim() + " es " + id);
						 id = 0;
						 break;
					 }else
						 id++;
						 continue;
					 }
			   }
			   catch(InputMismatchException ex)
			   {
				   System.out.println("Eso no es un apellido. ");//InputMismatchException
				   in.next();
			   }
			   catch(EOFException ex2)
			   {
				   System.out.println("No existe un empleado con ese nombre ");
			   }
			   catch(IOException ex3)
			   {
				   System.out.println("No existe ese archivo.");
			   }
		   }
	}

}
