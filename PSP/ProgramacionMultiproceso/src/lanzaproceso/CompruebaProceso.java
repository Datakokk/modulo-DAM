package lanzaproceso;

import java.io.IOException;
import java.util.Arrays;

public class CompruebaProceso {

    public static void main(String[] args) {
        // Cambiamos el comando para Ubuntu
        String[] comando = {"/bin/bash", "./bucle.sh"};
        ProcessBuilder pb = new ProcessBuilder(comando);
        pb.inheritIO();
        
        try {
            System.out.println("------------------------------------------------------------------------------------");
            System.out.println("Soy el proceso que ejecuta el programa Java CompruebaProceso. Mi pid en Linux es: " + ProcessHandle.current().toString());
            Process p = pb.start();
            System.out.println("Acabo de lanzar el script Linux bucle.sh cuyo pid es: " + p.pid());
            
            while(p.isAlive()) {
                System.out.println("Soy el proceso del programa Java CompruebaProceso - pid: " + ProcessHandle.current().toString());
                Thread.sleep(3000); // esperamos 3 segundos
            }
            
            int codRet = p.waitFor();
            System.out.println("------------------------------------------------------------------------------------");
            System.out.println("La ejecución del proceso " + Arrays.deepToString(comando) + " con pid " + p.pid() + " devuelve " + codRet + " " + 
            (codRet == 0 ? "(ejecución correcta)" : "(Error)")); 
            
        }
        catch(IOException e) {
            System.err.println("Error durante la ejecución del proceso");
            System.err.println("Información detallada");
            System.out.println("------------------------------------------------------------------------------------");
            e.printStackTrace();
            System.out.println("------------------------------------------------------------------------------------");
            System.exit(2);
        }
        catch(InterruptedException ie) {
            System.err.println("Proceso interrumpido");
            System.exit(3);
        }
                
    }

}
