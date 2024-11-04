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
	
		while(true) { // Recorremos todo el archivo hasta encontrar
			try {	  // un registro cuyo nombre coincida con el introducido
				int id=1;
				System.out.print("Indica el apellido del empleado del que quieres el número: ");
				String apellidoLeido=in.next(); // Lee el string introducido  
				apellidoLeido.trim();
				
				int dep, posicion;
				Double salario;
				char apellido[] = new char[10];

				// Lectura de registro del archivo
				posicion=0;
				while(true) {
					posicion=(id-1)*36; // estructura 4int, 10(x2)char, 4int, 8double 
					file.seek(posicion+4); // Nos ponemos donde empieza el apellido
					for (int i=0;i<apellido.length;i++) {  // Leemos el apellido
						apellido[i]=file.readChar();	  // carácter a carácter.
//						System.out.println("Letra leída: "+apellido[i]);
					}
					String apellidoEnFichero="".valueOf(apellido).trim();
					System.out.println("Apellido leído: "+apellidoLeido);
					System.out.println("Apellido en disco: "+apellidoEnFichero);

					if (apellidoLeido.equals(apellidoEnFichero))
					{	
						System.out.println("El número del empleado "+apellidoLeido+" es "+id);
						break;
					}
					else
					{
						id++; // Paso al siguiente registro
						continue;
					}
				}
			}
			catch(InputMismatchException ex) //InputMismatchException
			{
				System.out.println("Eso no es un apellido.");
				in.next();
			}
			catch(EOFException ex2) //EOFException. 
									//Se ha intentado leer más allá del final.
			{
				System.out.println("No existe ningún empleado con ese nombre. ");
			}
			catch(IOException ex3) //IOException
			{
				System.out.println("No existe ese archivo. ");
			}
		}
	}
}