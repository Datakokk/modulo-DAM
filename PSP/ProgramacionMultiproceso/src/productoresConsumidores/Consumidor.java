package productoresConsumidores;

public class Consumidor extends Thread{
	ColaSincronizada cola;
	int num;
	String ele;
	
	public Consumidor(ColaSincronizada c, int num) {
		this.cola = c;
		this.num = num;
	}
	
	@Override
	public void run() {
		// TODO Auto-generated method stub
		this.ele = cola.extraer();
		System.out.println("Consumidor: " + this.num + ", consume: " + this.ele);
	}
	
}
