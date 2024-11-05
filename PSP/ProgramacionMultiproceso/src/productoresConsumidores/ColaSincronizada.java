package productoresConsumidores;

public class ColaSincronizada {
	private int cima, capacidad;
	String[] vector;
	
	public ColaSincronizada(int i) {
		this.cima = 0;
		this.capacidad = i;
		this.vector = new String[i];
	}
	
	synchronized public String extraer() {
		
		while(this.cima == 0) {// Si cima es cero el hilo(productor) que llama a extraer() se suspende temporalmente
			try {
				this.wait();
			}catch (InterruptedException ie) {}
		}
		
		this.cima -=1;// Si cima > 0, el hilo consumidor sigue y decrementa cima
		
		System.out.println("Extraido: " + this.vector[cima] + " cima: " + this.cima);
		
		this.notifyAll();// Esto despierta a todos los hilos que podrian estar esperando en wait()
		
		return this.vector[cima];// Se retorna el valor del elemento que se extrajo.
	}
	
	synchronized public void insertar(String ele) {
		while (this.cima == this.capacidad-1) {// verificamos que la cola esta llena
			try {
				this.wait(); //suspendemos temporalmente el hilo
			}catch(InterruptedException ie) {}
			
		}
		
		this.vector[cima] = ele;
		this.cima += 1;//cuando hay espacio en la cola, el productor agrega cima
		
		System.out.println("Insertado: " + this.vector[cima-1] + " cima: " + this.cima);
		
		this.notifyAll();// Esto despierta a los hilos y evita el interbloqueo.
	}
}
