package comunicacionesEnRed;

import java.io.*;
import java.net.*;

public class EjemploURLConnection {

	public static void main(String[] args) {
		URL url = null;
		URLConnection urlCon = null;
		URI uri = null;
		
		try {
			uri = new URI(args[0]);
			url = uri.toURL();
			urlCon = url.openConnection();
			
			BufferedReader in;
			
			InputStream inputStream = url.openStream();
			in = new BufferedReader(new InputStreamReader(inputStream));
			
			String inputLine;
			while((inputLine = in.readLine()) != null) {
				System.out.println(inputLine);
			}
			
			in.close();
		}catch(MalformedURLException e) {
			e.getMessage();
			e.printStackTrace();
		} catch (IOException e) {
			
			e.printStackTrace();
		} catch (URISyntaxException e) {
			
			e.printStackTrace();
		}
	}

}
