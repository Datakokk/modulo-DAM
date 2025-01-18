package socketsUDP;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class ServidorTCPobjetos {

	private static final int PUERTO = 6000; 
	
	public static void main(String[]  args) {
	System.out.println("Inicio del programa Servidor ....................");
	
		try(ServerSocket servidor = new ServerSocket(PUERTO)){// Try-with resources para el socket del Serivdor
			System.out.println("Esperando conexión con el puerto: " + servidor.getLocalPort());
			
			try(Socket cliente = servidor.accept()){// Try-with-resources para el socket del Clienete
				System.out.println("Cliente conectado desde " + cliente.getInetAddress());
				
				try(ObjectOutputStream flujoSalidaObjetos = new ObjectOutputStream(cliente.getOutputStream());
					ObjectInputStream flujoEntradaObjetos = new ObjectInputStream(cliente.getInputStream())){//try-with-resources para los streams
					
					Persona personaEnviar = new Persona("Fernando", 12);
					flujoSalidaObjetos.writeObject(personaEnviar);
					System.out.println("Objeto enviado: " + personaEnviar.getNombre() + " Edad: " + personaEnviar.getEdad());
					
					Persona personaRecibir = (Persona) flujoEntradaObjetos.readObject();
					System.out.println("Recibido objeto: " + personaRecibir.getNombre() + " Edad: " + personaRecibir.getEdad());
				
				} // Los Stream se cierran automaticamente aqui
				catch (ClassNotFoundException e) {
					e.printStackTrace();
				}
			
			}// El socket del cliente se cierra automaticamente aqui
		
		}catch(IOException e) {
			e.getStackTrace();
		} // Ek socket del servidor se cierra automaticamente aqui

		System.out.println("Fin del programa Servidor!!!");
	}

}
