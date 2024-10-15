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
			//Simulamos un retraso de unos milisegundoos 
			Thread.sleep(10);
			
			//Imprimir el nombre del hilo y el mensaje procesado
			System.out.println(getName() + " (Prioridad: " + getPriority() + ") esta procesando: " + mensaje);
		}catch(InterruptedException ie) {
			// Manejamos la excepcion en caso que el hilo se interrumpa.
			System.out.println(getName() + "se ha interrumpido.");
		}
	}
	
	//Sobreescribimos el metodo run para definir lo que ace el hilo cuando se ejecuta
	@Override
	public void run() {
		// Llamamos el metodo para procesar el mensaje.
		ImprimirMensajeConRetraso();
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		List<Trabajador> trabajadores = new ArrayList<>();
		
		// Crear mensaje
		String[] mensajes = {"Mensaje 1", "Mensaje 2", "Mensaje 3", "Mensaje 4", "Mensaje 5"};
		
		// Crear trabajadores
		for(int i=0; i<mensajes.length; i++) {
			//Crear nuevo trabajador, la creamos con prioridad minima, segun vaya avanzando el array esta prioridad cambiar
			Trabajador trabajador = new Trabajador("Trabajador-" + (i+1), Thread.MIN_PRIORITY + i, mensajes[i] );
			// Agregamos el trabajador a la lista mensajes
			trabajadores.add(trabajador);
		}
		
		//Iniciamos los trabajadores de la lista
		for(Trabajador trabajador : trabajadores)
			trabajador.start();
		
		//El hilo principal finaliza sin que los trabajadores hayan finalizado
		System.out.println("El hilo principal ha finalizado");
	}

}
