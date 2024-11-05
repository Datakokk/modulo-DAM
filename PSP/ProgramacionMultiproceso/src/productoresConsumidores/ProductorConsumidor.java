package productoresConsumidores;

public class ProductorConsumidor {
	
	static ColaSincronizada cola = new ColaSincronizada(3);
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Productor p1 = new Productor(cola, 1, "web1");
		Productor p2 = new Productor(cola, 2, "web2");
		Productor p3 = new Productor(cola, 3, "web3");
		Productor p4 = new Productor(cola, 4, "web4");
		Productor p5 = new Productor(cola, 5, "web5");
		Consumidor c1 = new Consumidor(cola, 1);
		Consumidor c2 = new Consumidor(cola, 2);
		Consumidor c3 = new Consumidor(cola, 3);
		Consumidor c4 = new Consumidor(cola, 4);
		Consumidor c5 = new Consumidor(cola, 5);
		
		p1.start(); p2.start(); p3.start(); p4.start(); p5.start();
		c1.start(); c2.start(); c3.start(); c4.start(); c5.start();
		
		try {
			p1.join(); p2.join(); p3.join(); p4.join(); p5.join();
			c1.join(); c2.join(); c3.join(); c4.join(); c5.join();
		}catch(InterruptedException i) {
			System.out.println("Fin de programa");
		}
	}

}
