package comunicacionesEnRed;

import java.net.InetAddress;
import java.net.UnknownHostException;

public class TestInetAddress {

	public static void main(String[] args) {
		InetAddress dir;
		
		System.out.println("==============================================================");
		try {
			System.out.println("Salida para Localhost: ");
			dir = InetAddress.getLocalHost();
			pruebaMetodos(dir);
			
			System.out.println("\n==============================================================");
			System.out.println("Salida para URL: ");
			dir = InetAddress.getByName("www.vg.no");
			pruebaMetodos(dir);
			
			System.out.println("\n==============================================================");
			System.out.println("Direcciones IP para: " + dir.getHostName());
			InetAddress[] direcciones = InetAddress.getAllByName(dir.getHostName());
			for(int i = 0; i < direcciones.length; i++) {
				System.out.println("\t" + direcciones[i].toString());
			}
			System.out.println("\n==============================================================");
		}catch(UnknownHostException e) {
			e.printStackTrace();
		}
	}
	
	private static void pruebaMetodos(InetAddress dir) {
		System.out.println("\tmetodo getByName(): " + dir);
		InetAddress dir2;
		
		try {
			dir2 = InetAddress.getLocalHost();
			System.out.println("\tmetodo getLocalHost(): " + dir2);
		} catch(UnknownHostException e) {
			e.printStackTrace();
		}
		System.out.println("\tmetodo getHostName(): " + dir.getHostName());
		System.out.println("\tmetodo getHostAddress(): " + dir.getHostAddress());
		System.out.println("\tmetodo toString(): " + dir.toString());
		System.out.println("\tmetodo getCanonnicalHostName(): " + dir.getCanonicalHostName());
	}

}
