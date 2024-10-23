package recursoscompartidos;


public class ComprarBoletos extends Thread{
	private ReservaBoletos reserva; //Objeto donde tenemos la funcion sincronizada comprar boletos
	
	public ComprarBoletos(String nombreCliente, ReservaBoletos reserva) {
		super(nombreCliente); //Nombre del cliente que en realidad es el nombre de nuestro hilo
		this.reserva = reserva;
	}
	
	// Se compra 10 boletos tres veces.
	@Override
	public void run() {
		for(int i=0; i<3; i++) {
			reserva.comprarBoletos(this.getName(), 10);
		}
	}
}
