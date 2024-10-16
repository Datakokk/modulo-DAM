package hilos;

public class LanzaHilos {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Thread h1 = new Thread(new MiHilo("Hilo 1"));
		Thread h2 = new Thread(new MiHilo("Hilo 2"));
		Thread h3 = new Thread(new MiHilo("Hilo 3"));
		
		h1.start();
		h2.start();
		h3.start();
		
		System.out.println("El programa ha lanzado todos los hilos");
		
		try {
			h1.join();
			h2.join();
			h3.join();
		}
		catch(InterruptedException ie) {
			System.out.println("Se ha interrumpido el hilo");
		}
		
	}

}
