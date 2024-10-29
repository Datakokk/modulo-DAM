package bloqueo;

public class SimuladorTransferencias {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Cuenta c1 = new Cuenta("ES123456", 5050);
		Cuenta c2 = new Cuenta("ES223458", 3040);
		Cuenta c3 = new Cuenta("ES323459", 2040);
		Cuenta c4 = new Cuenta("ES423457", 9000);
		
		System.out.printf("Saldo inicial de %s: %d\n", c1.getNumeroCuenta(), c1.getSaldo());
		System.out.printf("Saldo inicial de %s: %d\n", c4.getNumeroCuenta(), c4.getSaldo());
		System.out.printf("Saldo inicial de %s: %d\n", c3.getNumeroCuenta(), c3.getSaldo());
		System.out.printf("Saldo inicial de %s: %d\n", c2.getNumeroCuenta(), c2.getSaldo());
		System.out.println("-----------------------------------------------------------");
		
		Thread h1 = new Thread(new HiloTransferencia(c1, c4, "Hilo 1"));
		Thread h2 = new Thread(new HiloTransferencia(c2, c3, "Hilo 2"));
		Thread h3 = new Thread(new HiloTransferencia(c3, c2 "Hilo 3"));
		Thread h4 = new Thread(new HiloTransferencia(c4, c1, "Hilo 4"));
		
		h1.start();
		h2.start();
		h3.start();
		h4.start();
		
		try {
			h1.join();
			h2.join();
			//h3.join();
			//h4.join();
			
		} catch (InterruptedException e) {
			// TODO: handle exception
			e.printStackTrace();
		}
		
		System.out.println("-----------------------------------------------------------");
		System.out.printf("Saldo final de %s: %d\n", c1.getNumeroCuenta(), c1.getSaldo());
		System.out.printf("Saldo final de %s: %d\n", c2.getNumeroCuenta(), c2.getSaldo());
		System.out.printf("Saldo final de %s: %d\n", c3.getNumeroCuenta(), c3.getSaldo());
		System.out.printf("Saldo final de %s: %d\n", c4.getNumeroCuenta(), c4.getSaldo());
	}

}
