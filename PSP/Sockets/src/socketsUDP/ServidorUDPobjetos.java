package socketsUDP;

import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.net.DatagramPacket;
import java.net.DatagramSocket;

public class ServidorUDPobjetos {

	private static final int PUERTO = 12345;
	
	public static void main(String[] args) throws IOException {
		// buffer para recibir el datagrama
		byte[] buffer = new byte[1024];
		
		try(DatagramSocket socket = new DatagramSocket(PUERTO)) {// Try with resources para cerrar cada recurso cuando se complete el bloque try
			System.out.println("Esperando Datagrama.......................");
			
			DatagramPacket datagramPacket = new DatagramPacket(buffer, buffer.length);
			socket.receive(datagramPacket);//Recibimos el datagrama 
			
			try( ByteArrayInputStream flujoBytes = new ByteArrayInputStream(buffer);
				 ObjectInputStream flujoObjetos = new ObjectInputStream(flujoBytes)	){/// Creamos un stream de objetos dentro del stream  de array de bytes

				//Convertimos el Datagrama a un objeto persona
				Persona persona = (Persona) flujoObjetos.readObject();
				System.out.println("El objeto recibido es: " + persona.getNombre() + " edad: " +persona.getEdad());
			
			}catch(ClassNotFoundException e) {
				System.err.println("La clase Persona no ha sido encontrada durante la deserializacion");
				e.printStackTrace();
			
			}catch(ClassCastException e) {
				System.out.println("Error: El objeto recibido no es de tipo Persona.");
				e.printStackTrace();
			}
		}catch (java.net.SocketException e) {
			System.err.println("Error al crear el socket " + e.getMessage());
			e.printStackTrace();
		}
	}

}
