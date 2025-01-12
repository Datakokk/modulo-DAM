package accesoFicheros;
import java.io.*;

public class GestionarDirectorio {

	public static void main(String[] args) 
	{
		String basePath = System.getProperty("user.dir");
		String directoriobasePath = basePath + File.separator + "accesoDatosDirectorio";
		
		// 1. Creamos el directorio "accesoDatosDirectorio"
		File directorio = new File(directoriobasePath);
		
		if(directorio.mkdir()) {
		// 2. Comprobamos si el directorio fue creado
			System.out.println("Directorio creado exitosamente: " + directorio.getAbsolutePath());
		}else {
			System.out.println("No se ha podido crear el directorio");
			return;
		}
		
		// 3. Creamos un par de ficheros dentro de este directorio
		File f1 = new File(directorio, "fichero1.txt");
		File f2 = new File(directorio, "fichero2.txt");
		
		try {
		  if (f1.createNewFile())
			System.out.println("Creado el nuevo fichero1: "+ f1.getName());
		  else 
			System.out.println("No se ha podido crear el nuevo fichero 1");
		
		  if (f2.createNewFile()) 
			System.out.println("Creado el nuevo fichero2: "+ f2.getName());
		  else 
			System.out.println("No se ha podido crear el nuevo fichero 2");
		}
		catch (IOException ioe) {
			System.out.println("Error al crear los archivos. "+ ioe.getMessage());
			ioe.printStackTrace();}
			
		/**if (f1.renameTo(new File(directorio,"NUEVOARCHIVO1")))
			System.out.println("Renombrado el fichero 1");
		else
			System.out.println("No se ha podido renombrar el fichero 1");
		**/
		
		// 4. Listamos el contenido del directorio
		System.out.println("Contenido del directorio: ");
		String[] contenido = directorio.list();
		
		if(contenido != null) {
			for(String nombre : contenido) {
				System.out.println(nombre);
			}
		}
		
		// 5. Eliminar los ficheros creados y luego el directorio
			// 5.1. Eliminar ficheros
			if (f1.delete())
				System.out.println("fichero1 borrado");
			else
				System.out.println("No se ha podido borrar el fichero1");
			if (f2.delete())
				System.out.println("fichero2 borrado");
			else
				System.out.println("No se ha podido borrar el fichero2");
			
			// 5.2 Eliminar directorio
			if(directorio.delete()) {
		// 6. Comprobamos si el directorio fue eliminado
				System.out.println("Directorio eliminado");
			}else {
				System.out.println("El directorio: "+directorio.getName() + " aun existe.");
			}
		
			
	}
			
}		
	

