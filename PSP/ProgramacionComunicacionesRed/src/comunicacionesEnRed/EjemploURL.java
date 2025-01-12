package comunicacionesEnRed;

import java.net.MalformedURLException;
import java.net.URI;
import java.net.URISyntaxException;
import java.net.URL;

public class EjemploURL {

	public static void main(String[] args) {
		URI uri = null;
		URL url = null;
		
		// A partir de Java20, el constructor URL(String) ha sido marcado como deprecated
		try {
			System.out.println("Constructore simple para una URL:");
			uri = new URI("http://docs.oracle.com");
			url = uri.toURL();
			visualizar(url);
			
			System.out.println("Otro constructor simple para una URL:");
			uri = new URI("http://localhost/PFC/gest/cli_gestion.php?ids=3");
			url = uri.toURL();
			visualizar(url);
			
			System.out.println("Constructor para protocolo + URL + directorio:");
			uri = new URI("http", "docs.oracle.com", "/javase/10/");
			url = uri.toURL();
			visualizar(url);
			
			System.out.println("Constructor para protocolo + URL + puerto + directorio:");
			uri = new URI("http", "localhost", null, 8084, "/WebApp/Controlador?action=modificar", null, null);
			url = uri.toURL();
			visualizar(url);
			
			System.out.println("Constructor para un objeto URL en un contexto:");
			URI uriBase = new URI("http://docs.oracle.com");
			uri = uriBase.resolve("/javase/10/docs/api/java/net/URL.html");
			url = uri.toURL();
			visualizar(url);
			
		}catch(MalformedURLException | URISyntaxException e) {
			e.printStackTrace();
		}

	}
	
	public static void visualizar(URL url) {
		System.out.println("URL Completa: " + url.toString());
		System.out.println("getProtocol() : " + url.getProtocol());
		System.out.println("getHost() : " + url.getHost());
		System.out.println("getPort() : " + url.getPort());
		System.out.println("getFile() : " + url.getFile());
		System.out.println("getUserInfo() : " + url.getUserInfo());
		System.out.println("getPath() : " + url.getPath());
		System.out.println("getAuthority() : " + url.getAuthority());
		System.out.println("getQuery() : " + url.getQuery());
		System.out.println("getDefaultPort() : " + url.getDefaultPort());
		System.out.println("====================================================");
	}

}
