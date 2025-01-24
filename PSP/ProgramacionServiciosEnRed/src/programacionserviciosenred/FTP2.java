package programacionserviciosenred;

import java.io.IOException;

import org.apache.commons.net.ftp.FTPClient;
import org.apache.commons.net.ftp.FTPFile;

public class FTP2 {

	public static void main(String[] args) {
		FTPClient cliente = new FTPClient();
		String servFTP = "ftp.rediris.es"; // Servidor FTP al cual nos conectamos.
		System.out.println("Nos conectamos a: " + servFTP);
		String usuario = "anonymous";
		String clave = "anonymous";
		
		try {
			cliente.connect(servFTP);
			cliente.enterLocalPassiveMode(); // Modo pasivo
			
			boolean login = cliente.login(usuario, clave);
			if(login) {
				System.out.println("El login se ha realizado correctamente");
			
			}else {
				System.out.println("El login no se ha podido realizar");
				cliente.disconnect();
				System.exit(1);
			}
			
			System.out.println("Directorio actual: " + cliente.printWorkingDirectory());
			
			FTPFile[] files = cliente.listFiles(); // Array para visualizar el tipo de fichero.
			System.out.println("Ficheros en el directorio actual: " + files.length);
			
			// Creamos un array para asignar los codigos devueltos al tipo de archivo
			// 0 => Fichero
			// 1 => Directorio
			// 2 => Enlace simb
			
			String tipos[] = {"Fichero", "Directorio", "Enlace simb."};
			
			for(int i = 0; i < files.length; i++) {
				System.err.println("\t" + files[i].getName() + " => " + tipos[files[i].getType()]);
			}
			
			boolean logout = cliente.logout();
			if(logout)
				System.err.println("Logout del servidor FTP ....");
			else
				System.out.println("Error al hacer logout....");
			
			// Desconexion del servidor FTP
			cliente.disconnect();
			System.out.println("Conexión finalizada.");
			
		}catch(IOException e) {
			e.printStackTrace();
		}
	}

}
