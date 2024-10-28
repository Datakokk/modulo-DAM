package bloqueo;

public class Cuenta {

		private int saldo;
		private final String numeroCuenta;
		
		public Cuenta(String numeroCuenta, int saldo) {
			this.saldo = saldo;
			this.numeroCuenta = numeroCuenta;
		}
		
		public int getSaldo() {
			return this.saldo;
		}
	
		public String getNumeroCuenta() {
			return this.numeroCuenta;
		}
		
		public void ingresarDinero(int cantidad) {
			this.saldo += cantidad;
		}
		
		public void retirarDinero(int cantidad) {
			this.saldo -= cantidad;
		}

}
