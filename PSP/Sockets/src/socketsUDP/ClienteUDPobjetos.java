package socketsUDP;

import java.io.ByteArrayOutputStream;
import java.io.ObjectOutputStream;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.Socket;
import java.net.SocketException;
import java.net.UnknownHostException;

public class ClienteUDPobjetos {

	public static void main(String[] args) throws Exception{
		int puerto = 12345;
		InetAddress destino = InetAddress.getLocalHost();
		
		try(DatagramSocket datagramSocket = new DatagramSocket(); // Try with resources para cerrar cada recurso cuando se complete el bloque try
			ByteArrayOutputStream flujoSalida = new ByteArrayOutputStream();// Stream de array de bytes de salida para obtener un buffer para el paquete
			ObjectOutputStream flujoObjeto = new ObjectOutputStream(flujoSalida)){// Creamos un stream de objetos dentro del stream  de array de bytes
			
			// Creamos el objeto Persona
			Persona persona = new Persona("Fernando", 12);
			
			// Metemos el objeto Perosna dentro del stream de objetos( strean array de bytes[])
			flujoObjeto.writeObject(persona);
			
			// Obtenemos un bufer para enviar el datagrama del stream de array de bytes
			byte[] buffer = flujoSalida.toByteArray();
			
			//Enviamos el datagrama al servidor
			DatagramPacket paqueteEnviado = new DatagramPacket(buffer, buffer.length, destino, puerto);
			datagramSocket.send(paqueteEnviado); // Enviamos el datagrama al servidor
			System.out.println("Mensaje enviado....");
			
			
		}catch(java.net.UnknownServiceException e) {
			e.getMessage();
		}

	}

}
