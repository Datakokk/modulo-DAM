package socketsUDP;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;

public class ServidorInteractivoUDP {
	
	// Asociamos el socket al puerto 12345
	private static final int PUERTO_SERVIDOR = 12345;
	
	
	public static void main(String[] args) throws IOException {
		
		 DatagramSocket socketServidor = new DatagramSocket(PUERTO_SERVIDOR);

	        // Esperamos el Datagrama del cliente
	        System.out.println("Esperando Datagrama ........ ");
	        DatagramPacket paqueteRecibido;
	        byte[] bufferRecepcion = new byte[1024]; // buffer donde recibiremos  el datagrama
	        paqueteRecibido = new DatagramPacket(bufferRecepcion, bufferRecepcion.length);
	        socketServidor.receive(paqueteRecibido); // RECIBIMOS DATAGRAMA

	        String mensaje = new String(paqueteRecibido.getData()).trim(); // obtenemos  String
	        System.out.println("Servidor recibe : " + mensaje);

	        // CONTAMOS EL NÚMERO DE LETRAS a
	        int contLetra = 0;
	        for (int i = 0; i < mensaje.length(); i++) {
	            if (Character.toLowerCase(mensaje.charAt(i)) == 'a') 
	            	contLetra++;
	        }

	        // DATOS DEL CLIENTE
	        InetAddress ipCliente = paqueteRecibido.getAddress();
	        int puertoCliente = paqueteRecibido.getPort();

	        // ENVIAMOS RESPUESTA AL CLIENTE
	        System.out.println("Enviado contador de letra 'a' : " + contLetra);
	        byte b = (byte) contLetra; // codificamos el número para poder enviarlo
	        byte[] bufferEnvio = new byte[1024]; // buffer para enviar el datagrama
	        bufferEnvio[0] = b;

	        DatagramPacket paqueteEnvio = new DatagramPacket(bufferEnvio, bufferEnvio.length, ipCliente, puertoCliente);
	        socketServidor.send(paqueteEnvio);

	        // CERRAMOS EL SOCKET
	        System.out.println("Cerrando conexión...");
	        socketServidor.close(); // cerramos el socket
		
	}

}
