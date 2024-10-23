package recursoscompartidos;

public class CompartiendoReservaCliente {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ReservaBoletos reserva = new ReservaBoletos(30); // Este es le recurso compartido
		
		ComprarBoletos cliente1 = new ComprarBoletos("Else", reserva);
		ComprarBoletos cliente2 = new ComprarBoletos("Anne", reserva);
		
		cliente1.start();
		cliente2.start();
	}

}
