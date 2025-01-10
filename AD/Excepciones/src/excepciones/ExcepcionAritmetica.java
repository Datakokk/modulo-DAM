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
				
				int resultado = dividendo/divisor;
				System.out.println("El resultado es: " + resultado);
				
				break; //Salimos de la operación si fue exitosa.
				
			}catch (ArithmeticException e) {
				// TODO: handle exception
				System.out.println("Error: No se puede dividir por cero. Por favor, ingrese nuevos números.");
			}catch (Exception e) {
				// TODO: handle exception
				System.out.println("Error: Entrada no válida. Por favor, ingrese números enteros.");
                scanner.next(); // Limpiamos la entrada que no es válida.
			}
		}
		scanner.close();
	}
}
