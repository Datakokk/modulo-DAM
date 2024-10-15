package accesoFicheros;

import java.io.EOFException;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.InputMismatchException;
import java.util.Scanner;

public class LeerRegistro {
	
    public static void main(String[] args) throws FileNotFoundException, IOException {
        // TODO Auto-generated method stub
        String path ="C:\\Users\\heily\\OneDrive\\Escritorio\\Fichero_Ejercicios";
        File fichero = new File(path + "AleatorioEmple.txt");
        RandomAccessFile file = new RandomAccessFile(fichero, "r");
        Scanner in = new Scanner(System.in);
        int id;

        while (true) {
            try {
                System.out.print("Indica el número de empleado que deseas ver: ");
                id = in.nextInt();
                int dep, posicion;
                double salario;
                char[] apellido = new char[10];
                posicion = (id - 1) * 36;
                file.seek(posicion);
                id = file.readInt();
                for (int i = 0; i < apellido.length; i++) {
                    apellido[i] = file.readChar();
                }
                String apellidoS = new String(apellido);
                dep = file.readInt();
                salario = file.readDouble();

                System.out.println("ID empleado: " + id + " - Apellido: " + apellidoS + " - Depto: " + dep + " - Salario: " + salario);
                System.out.println();

            } catch (InputMismatchException ex) {
                System.out.println("Eso no es un número de empleado.");
                in.next(); // Para limpiar el buffer de entrada

            } catch (EOFException ex2) {
                System.out.println("No existe ese número de empleado.");

            } catch (IOException ex3) {
                System.out.println("Error al leer el archivo.");
            }
        }
    }
}