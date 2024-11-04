package accesoFicheros;
import java.io.*;

public class crearDir {

	static String path="C:\\Users\\tarde\\eclipse-workspace\\accesoFicheros\\src\\accesoFicheros\\";
	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		File d= new File(path+"NUEVODIR\\");
		File f1 = new File(path+"FICHERO1.txt");
		File f2 = new File(path+"FICHERO2.txt");
		
		d.mkdir(); // Crear directorio
		
		try {
		  if (f1.createNewFile())
			System.out.println("Creado el nuevo archivo 1");
		  else 
			System.out.println("No se ha podido crear el nuevo archivo 1");
		
		  if (f2.createNewFile()) 
			System.out.println("Creado el nuevo archivo 2");
		  else 
			System.out.println("No se ha podido crear el nuevo archivo 2");
		}
		catch (IOException ioe)
			{ ioe.printStackTrace();}
			
		if (f1.renameTo(new File(d,"NUEVOARCHIVO1")))
			System.out.println("Renombrado el archivo 1");
		else
			System.out.println("No se ha podido renombrar el archivo 1");
		
		try {
			File f3 = new File(path+"\\NUEVODIR\\FICHERO3.txt");
			f3.createNewFile();
			f3.renameTo(new File(path+"\\NUEVODIR\\NUEVOARCHIVO3.txt"));
		//	if (f3.delete())
		//		System.out.println("Fichero 3 borrado");
		//	else
		//		System.out.println("No se ha podido borrar el Fichero 3");
		}	
		catch (Exception ioe2)
			{ ioe2.printStackTrace();}
			
	}
			
}		
	

