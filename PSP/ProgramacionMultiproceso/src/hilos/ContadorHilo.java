package hilos;

import java.util.Scanner;

public class ContadorHilo extends Thread{
	
	private ControlSuspension suspender = new ControlSuspension();// Objeto monitor
	private boolean detieneHilo = false;
	private int contador = 0;
		
	public void suspende() {
		System.out.println("Se ha suspendido el hilo - contador: "+contador);
		suspender.set(true);// Hara que el hilo se desbloquee pero luego se bloquea en el método run()
	}
	
	public void reanuda() {
		System.out.println("El hilo se ha reanudado - contador: "+contador);
		suspender.set(false);// Hara que el hilo se desbloquee y luego progrese en el método run()
	}
	public void detenerHilo() {
		this.reanuda();//  Lo reanudamos antes de pararlo en caso de que estuviese suspendido
		this.detieneHilo = true;
	}
	@Override 
	public void run() {
		while(!detieneHilo) {
			try {
				suspender.esperandoReanudar();//El hilo comprueba si puede seguir o tiene que esperar
				contador++;
				Thread.sleep(100);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				System.out.println("Excepcion en run(): " + e.toString());
			}
		}
	}
	
	public static void main(String[] args){
		// Iniciamos un hilo
		ContadorHilo h = new ContadorHilo();
		
		// Obtenemos el tiempo antes de iniciar elhilo
		long inicio = System.currentTimeMillis();

		// Iniciamos el hilo
		h.start();
		
		//Leemos por teclado
		Scanner lectura = new Scanner(System.in);
		String txtRecibido;
		System.out.println("Introducir 'S'-> para suspender | 'R'-> para reanudar | 'T'-> para terminar: ");
		txtRecibido = lectura.next();
		
		while(!txtRecibido.equals("T")) {
			if(txtRecibido.equals("S")) {
				h.suspende();// ponemos el hilo en espera
			}else if(txtRecibido.equals("R")) {
				h.reanuda();// reanudamos el hiolo
			}
			System.out.println("Introducir 'S'-> para suspender | 'R'-> para reanudar | 'T'-> para terminar: ");
			txtRecibido = lectura.next();
		}
		lectura.close();

		// Detenemos el hilo
		h.detenerHilo();
		
		//Obtener el tiempo despues de que el hilo ha terminado
		long fin = System.currentTimeMillis();
		//Double segundos = (double)fin/1_000_000_000.0;
		
		System.out.println("contador final: " + h.contador);
		System.out.println("El tiempo total de ejecución es de: " + (fin - inicio) + " ms");
		
	}

}
