package socketsUDP;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.InetAddress;
import java.net.MulticastSocket;
import java.util.Scanner;

public class ServidorMulticast {

	// IP multicast
	private static final String IPMULTICAST = "225.0.0.1";
	// IP servidor multicast
	private static final int PUERTO = 12345;
	// Palabra clave para finalizar la comunicacion
	private static final String FIN = "adios";
	
	private static Scanner sc = new Scanner(System.in);
	
	public static void main(String[] args) throws IOException {
		System.out.println("INICIO SERVIDOR MULTICAST......................");
		// Se crea el socket multicast
		MulticastSocket socketMulticast = new MulticastSocket(PUERTO);
		InetAddress ipMulticast = InetAddress.getByName(IPMULTICAST);
		
		String cadena = "";
		while(!cadena.trim().equals(FIN)) {
			System.out.println("Datos a enviar al grupo: ");
			cadena = sc.nextLine();
			// Preparamos el datagrama para el grupo
			DatagramPacket paquete = new DatagramPacket(cadena.getBytes(), cadena.length(), ipMulticast, PUERTO);
			//Enviamos al grupo
			socketMulticast.send(paquete);
		}
		socketMulticast.close();
		System.out.println("FIN SERVIDOR MULTICAST.........................................");
	}

}
