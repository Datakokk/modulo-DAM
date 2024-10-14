package hilos;

import java.util.ArrayList;
import java.util.List;

public class Trabajador extends Thread {
	private String mensaje;
	
	public Trabajador(String nombre, int prioridad, String mensaje) {
		super(nombre);
	}
	
	@Override
	public void run() {
		
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		List<Trabajador> trabajadores = new ArrayList<>();
		
		String[] mensajes = {
				
		};
		
	}

}
