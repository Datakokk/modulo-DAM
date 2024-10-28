package bloqueo;

public class GestorTransferenciasConInterbloqueo {
	
	public static boolean transferencia(Cuenta c1, Cuenta c2, int cantidad) {
		/*Cuenta cuentaMayor, cuentaMenor;
		if(c1.getNumeroCuenta().compareTo(c2.getNumeroCuenta()) < 0) {
			cuentaMenor = c1;
			cuentaMayor = c2;
		}else {
			cuentaMenor = c2;
			cuentaMayor = c1;
		}*/
		boolean result = false;
		synchronized (c1) {
			synchronized (c2) {
				if(c1.getSaldo() >= cantidad) {
					c1.retirarDinero(cantidad);
					c2.ingresarDinero(cantidad);
					result = true;
				}
			}
		}
		
		return result;
	}
}
