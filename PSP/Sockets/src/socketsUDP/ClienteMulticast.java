package socketsUDP;

import java.net.DatagramPacket;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.MulticastSocket;
import java.net.NetworkInterface;

public class ClienteMulticast {

	// IP multicast
	private static final String IPMULTICAST = "225.0.0.1";
	// Puerto servidor multicast
	private static final int PUERTO = 12345;
	// Palabra clave para finalizar la comunicacion
	private static final String FIN = "adios";
	
	public static void main(String[] args) throws Exception {
		System.out.println("INCIO CLIENTE MULTICAST ...........................");
		InetAddress ipGrupo = InetAddress.getByName(IPMULTICAST);

		// Creamos el socket multicast
		MulticastSocket socketMulticast = new MulticastSocket(PUERTO);
		
		// Nos unimos al grupo con socketMulticast.joinGroup(ipGrupo) --(Obsoleto desde version 14)
		socketMulticast.joinGroup(new InetSocketAddress(ipGrupo, PUERTO),
									NetworkInterface.getByInetAddress(InetAddress.getLocalHost()));
		
		String mensaje = "";
		while(!mensaje.trim().equals(FIN)) {
			byte[] buffer = new byte[1000];
			//Recibimos el paquete multicast
			DatagramPacket paquete = new DatagramPacket(buffer, buffer.length);
			socketMulticast.receive(paquete);
			
			mensaje = new String(paquete.getData());
			System.out.println("Recibo: " + mensaje.trim());
		}
		
		// socketMulticast.leaveGroup(ipGrupo) --(Obsoleto desde version 14)
		socketMulticast.leaveGroup(new InetSocketAddress(ipGrupo, PUERTO),
									NetworkInterface.getByInetAddress(InetAddress.getLocalHost()));
		
		socketMulticast.close();
		System.out.println("FIN CLIENTE MULTICAST .................................................");
	}

}
