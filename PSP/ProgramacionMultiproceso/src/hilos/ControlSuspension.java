package hilos;

public class ControlSuspension {
	private boolean suspender;
	
	public synchronized void set(boolean b) {
		suspender = b;
		this.notify();//Desbloquea un hilo en espera en el mismo monitor, existe otra version que desbloquea todos los hilos que 
		//estan esperando en el monitor y es "notifyAll()"
	}
	
	public synchronized void esperandoReanudar() throws InterruptedException {
		while(suspender) {
			this.wait();// Con este método bloqueamos el hilo hasta que alguno de los métodos lineas arribas descritas sea llamado.
		}
	}
}
