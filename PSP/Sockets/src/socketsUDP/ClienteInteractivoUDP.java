package socketsUDP;

import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.util.Scanner;

public class ClienteInteractivoUDP {

	
	public static void main(String[] args) throws Exception {
		Scanner sc = new Scanner(System.in);
		
		DatagramSocket socketCliente = new DatagramSocket();
		
		//Datos del servidor al que se enviara el mensaje
		InetAddress ipServidor = InetAddress.getLocalHost();
		int puerto = 12345;
		
		// Introducir datos por teclado
		System.out.println("Introduce un mensaje: ");
		String cadena = sc.nextLine();
		
		byte[] bufferEnvio = new byte[1024];
		bufferEnvio = cadena.getBytes(); // codificamos el mensaje para ser enviado
		
		// Enviamos Datagrama al servidor
		DatagramPacket paqueteEnviado = new DatagramPacket(bufferEnvio, bufferEnvio.length, ipServidor, puerto);
		socketCliente.send(paqueteEnviado);
		
		// Recibimos Datagrama del servidor
		byte[] bufferRecepcion = new byte[1];
		DatagramPacket paqueteRecibido = new DatagramPacket(bufferRecepcion, bufferRecepcion.length);
		System.out.println("Esperando datagrama.....");
		socketCliente.receive(paqueteRecibido);
		
		// Obtenemos el numero de caracteres
		byte[] bufferDatos = paqueteRecibido.getData();
		int numero = bufferDatos[0];
		System.out.println("Recibo Nº de caracteres que son a ==> :" + numero);
		
		socketCliente.close();
		
		sc.close();
	}

}
