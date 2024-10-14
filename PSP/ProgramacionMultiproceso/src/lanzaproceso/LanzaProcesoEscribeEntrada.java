package lanzaproceso;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;

public class LanzaProcesoEscribeEntrada {

    public static void main(String[] args) {
        // Definimos el comando para Linux (ya no usamos 'wsl')
        String[] comando = {""};
        ProcessBuilder pb = new ProcessBuilder(comando);

        try {
            // Creamos un InputStreamReader para leer la entrada estándar del usuario (desde consola)
            InputStreamReader isstdin = new InputStreamReader(System.in, "UTF-8");
            // BufferedReader se utiliza para leer el input del usuario línea por línea
            BufferedReader brstdin = new BufferedReader(isstdin);

            String linea; // Variable para almacenar la entrada del usuario

            // Solicita un nombre de dominio
            System.out.print("Introduce el nombre del dominio: ");

            // Bucle que sigue leyendo nombres de dominio hasta que se introduce una línea vacía
            while((linea = brstdin.readLine()) != null && linea.length() != 0) {
                // Iniciamos un proceso
                Process p = pb.start();

                try (
                    // Abrimos un OutputStream para escribir en la entrada estándar del proceso (stdin)
                    OutputStream os = p.getOutputStream();
                    // OutputStreamWriter se utiliza para escribir texto en la entrada del proceso
                    OutputStreamWriter oswp = new OutputStreamWriter(os, "UTF-8")) {

                    // Escribimos el nombre de dominio ingresado por el usuario en el proceso "nslookup"
                    oswp.write(linea + "\n");
                    oswp.flush(); // Nos aseguramos de que todo el texto se haya enviado al proceso

                } catch (IOException e) {
                    System.err.println("Error al enviar la entrada al proceso");
                    e.printStackTrace();
                }

                try (
                    // BufferedReader para leer la salida estándar del proceso (stdout)
                    BufferedReader br = new BufferedReader(new InputStreamReader(p.getInputStream()))) {

                    String lineaSalida;
                    // Leemos línea por línea la salida del proceso "nslookup" y la mostramos en pantalla
                    while((lineaSalida = br.readLine()) != null) {
                        System.out.println(lineaSalida);
                    }

                    // Esperamos a que el proceso termine
                    p.waitFor();

                } catch (IOException | InterruptedException e) {
                    System.err.println("Error al leer la salida del proceso");
                    e.printStackTrace();
                }

                // Solicitar otro dominio después de que el proceso anterior haya terminado
                System.out.print("Introduce el nombre del dominio: ");
            }

        } catch (IOException ioe) {
            System.err.println("Error de E/S");
            ioe.printStackTrace();
        }

        System.out.println("FIN");
    }
}
