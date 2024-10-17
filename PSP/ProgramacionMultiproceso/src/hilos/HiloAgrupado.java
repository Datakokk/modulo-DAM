package hilos;

public class HiloAgrupado extends Thread {

	@Override
	public void run() {
		System.out.println("Información del hilo: " + Thread.currentThread().toString());
		System.out.println(Thread.currentThread().getName() + " ha finalizado");
	}
	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		Thread.currentThread().setName("PRINCIPAL");
		System.out.println(Thread.currentThread().getName());
		System.out.println(Thread.currentThread().toString());
		
		ThreadGroup grupo = new ThreadGroup("MI GRUPO");
		HiloAgrupado hiA = new HiloAgrupado();
		
		Thread h1 = new Thread(grupo, hiA, "Hilo 1");
		Thread h2 = new Thread(grupo, hiA, "Hilo 2");
		Thread h3 = new Thread(grupo, hiA, "Hilo 3");
		
		h1.start();
		h2.start();
		h3.start();
		
		System.out.println("El número de hilos activos " + grupo.activeCount());
		
		try {
			Thread.sleep(1000);// Esperamos 1 segundo para esperar que todos los hilos inicien su ejecución
			grupo.interrupt(); // Interrumpimos todos los hilos del grupo.
			
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		System.out.println("El número de hilos activos " + grupo.activeCount());
		h1.join();
		h2.join();
		h3.join();
		
		
	}

}
