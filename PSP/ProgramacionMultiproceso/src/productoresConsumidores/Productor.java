package productoresConsumidores;

public class Productor extends Thread{
	private ColaSincronizada cola;
	private int num;
	private String ele;
	
	public Productor(ColaSincronizada c, int num, String ele) {
		this.cola = c;
		this.ele = ele;
		this.num = num;
	};
	
	@Override
	public void run() {
		// TODO Auto-generated method stub
		this.cola.insertar(ele);
		
		System.out.println("Productor: " + this.num + ", produce: " + this.ele);
	}
	
}
