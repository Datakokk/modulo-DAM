package socketsUDP;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.net.UnknownHostException;

public class ClienteTCPobjetos {

	public static void main(String[] args) {
		String hostServidor = "localhost";
		int puertoServidor = 6000;
		
		System.out.println("Programa Cliente iniciado......................................");
		
		try(Socket cliente = new Socket(hostServidor, puertoServidor);
			ObjectOutputStream flujoSalidaObjetos = new ObjectOutputStream(cliente.getOutputStream());// try with sources: para los streams y los sockets
			ObjectInputStream flujoEntradaObjetos = new ObjectInputStream(cliente.getInputStream());
		){
			// Leemos el objeto recibido de la clase Persona
			Persona persona = (Persona)flujoEntradaObjetos.readObject();
			System.out.println("Recibido el objeto: " + persona.getNombre() + " edad: " + persona.getEdad());
			
			// Creamos un objeto Persona nuevo
			Persona personaEnviado = new Persona("Fernando", 24);
			
			// Enviamos el nuevo objeto
			flujoSalidaObjetos.writeObject(personaEnviado);
			System.out.println("Objeto enviado: " + personaEnviado.getNombre() + " edad: " + personaEnviado.getEdad());
			
		} catch (UnknownHostException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}// Los streams y sockets se cierran automaticamente
	}

}
