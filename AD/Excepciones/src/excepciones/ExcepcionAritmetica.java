package excepciones;

import java.util.Scanner;

public class ExcepcionAritmetica {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);
		
		while(true) {
			try {
				
				System.out.println("Ingrese el dividendo: ");
				int dividendo = scanner.nextInt();
				
				System.out.println("Ingrese el divisor: ");
				int divisor = scanner.nextInt();
				
			}catch (ArithmeticException e) {
				// TODO: handle exception
			}catch (Exception e) {
				// TODO: handle exception
			}
		}
	}

}
