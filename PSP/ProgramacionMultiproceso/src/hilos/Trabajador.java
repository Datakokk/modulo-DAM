package hilos;

import java.util.ArrayList;
import java.util.List;

public class Trabajador extends Thread {
	private String mensaje;
	
	public Trabajador(String nombre, int prioridad, String mensaje) {
		super(nombre);
		this.mensaje = mensaje;
		setPriority(prioridad); //Establecemos la prioridad del hiflo
	}
	
	public void ImprimirMensajeConRetraso() {
		try {
			//Simulamos un retraso de dos segundos
			Thread.sleep(2000);
			
			//Imprimir el nombre del hilo y el mensaje procesado
			System.out.println("Ha procesado el mensaje" + mensaje);
		}catch(InterruptedException ie) {
			// Manejamos la excepcion en caso que el hilo se interrumpa.
			System.out.println(getName() + "se ha interrumpido.");
		}
	}
	
	@Override
	public void run() {
		// Llamamos el metodo para procesar el mensaje.
		ImprimirMensajeConRetraso();
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		List<Trabajador> trabajadores = new ArrayList<>();
		
		String[] mensajes = {"Mensaje 1", "Mensaje 2", "Mensaje 3", "Mensaje 4", "Mensaje 5"};
		
	}

}
