package hilos;

public class MiHilo implements Runnable{

	private final String nombre;
	
	// Constructor que recibe el nombre del hilo
	MiHilo (String n){
		this.nombre = n;
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		try {
			System.out.println(nombre + "ha comenzado.");
			
			// Generar el tiempo de pausa aleatorio entre 1 y 3 segundos
			int pausa = (int) (Math.random() * 2000) + 1000;
			
			// Pausar el hilo con el tiempo generado
			Thread.sleep(pausa);
			
			// Se imprime un mensaje  indicando el tiempo de pausa del hilo.
			System.out.println(Thread.currentThread().getName() + " se pausará por " + pausa + " ms");
			
			// Se imprime un mensaje indicando que el hilo ha finalizado
			System.out.println(nombre + " ha terminado.");
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			System.out.println(Thread.currentThread().getName() + " ha sido interrumpido");
			e.printStackTrace();
		}
	}

}
