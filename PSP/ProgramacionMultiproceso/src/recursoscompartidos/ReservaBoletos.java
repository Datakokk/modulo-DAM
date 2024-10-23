package recursoscompartidos;

public class ReservaBoletos {
	private int boletos;
	
	public ReservaBoletos(int b) {
		this.boletos = b;
	}
	
	public int getNumBoletos() {
		return this.boletos;
	}
	
	public void restar(int cantidad) {
		this.boletos -= cantidad;
	}
	
	public synchronized void comprarBoletos(String cliente, int cantidad) {
		 String singPlural = cantidad>1 ? " boletos":" boleto";
		 
		if(this.getNumBoletos() >= cantidad) {
				System.out.println(cliente + " Esta reservando " + cantidad + singPlural); 
				
				try {
					Thread.sleep(500);
				}catch (Exception e) {
					// TODO: handle exception
				}
				
				this.restar(cantidad);//Restamos la cantidad comprada al total 
				System.out.println(cliente + " ha comprado " + cantidad + singPlural + " -> Boletos restantes: "+ this.boletos);
				
		}else if(this.getNumBoletos() <= 0){
			System.out.println("Se han agotado las entradas para " + cliente + " -> Boletos restantes: "+ this.boletos);
			
		}else {
			System.out.println("No hay suficientes boletos para " + cliente + " -> Boletos restantes: "+ this.boletos);
		}
		
	}
	
}
