package bloqueo;


public class HiloTransferencia implements Runnable{
	Cuenta c1, c2;
	String nomHilo;
	
	public HiloTransferencia(Cuenta c1, Cuenta c2, String nombre) {
		this.c1 = c1;
		this.c2 = c2;
		this.nomHilo = nombre;
	}
	
	public String getNameHilo() {
		return this.nomHilo;
	}
	
	@Override
	public void run() {
		// TODO Auto-generated method stub
		int cantdad = 50;
		int numTransferencia = 0;
		
		for(int i=1; i<=5; i++) {
			if(GestorTransferenciasConInterbloqueo.transferencia(c1, c2, cantdad))
				numTransferencia++;
		}
		
		try {
			Thread.sleep(1000);
			
		} catch (InterruptedException e) {
			// TODO: handle exception
		}
		System.out.printf("Fin de %s, %d --> transferencia hecha de %s a %s.\n", this.getNameHilo(), numTransferencia, c1.getNumeroCuenta(), c2.getNumeroCuenta());
	}
	

}
