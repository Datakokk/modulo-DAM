package programacionserviciosenred;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.util.Properties;

import javax.mail.Folder;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Multipart;
import javax.mail.NoSuchProviderException;
import javax.mail.Session;
import javax.mail.Store;
import javax.mail.internet.MimeBodyPart;

public class LecturaCorreosPOP3 {
	
	private static final String HOST = "pop.gmail.com";
	private static final String USER_NAME = "fiodorelzarster";
	private static final String PASSWORD = "qygn cqir aykk rici";
	
	// En esta ruta tendremos nuestra carpeta de destino
	private static final String CARPETA_DESTINO = "/home/datakokk/DAM/PSP/";

	public static void main(String[] args) throws IOException, MessagingException { 
		Store store = null;
		Folder carpeta = null;
		
		try {
			Properties props = new Properties();
			// Google usa POP3(POP seguro)
			props.put("mail.store.protocol", "pop3s");
			props.put("mail.pop3s.ssl,protocols", "TLSv1.2");
			
			// Clase que reprenta una sesion de correo
			//Encapsula la configuracion y propiedades necesarias para conectarse a un servidor de correo
			Session session = Session.getDefaultInstance(props);
			
			//La clase Store proporciona métodos para conectarse, dexconectarse y acceder a buzones de correo de un servidor.
			store = session.getStore();
			store.connect(HOST, USER_NAME, PASSWORD);
			
			// Obtenemos todo el contenido del buzon de entrada
			carpeta = store.getDefaultFolder().getFolder("INBOX");
			carpeta.open(Folder.READ_ONLY);
			
			// Obtenemos los mensajes del buzon de entrada
			Message[] mensajes = carpeta.getMessages();
			System.out.println("Número de mensajes: " + carpeta.getMessageCount());
            System.out.println("Número de mensajes no leídos: " + carpeta.getUnreadMessageCount());
            
            // Recorremos todos los mensajes
            for(int i = 0; i < mensajes.length; i++) {
            	
            	System.out.println("Mensaje (" + (i +1) + "): ");
            	Message mensaje = mensajes[i];
            	
            	// Si el mensaje es de respuesta cogemos el primero para nuestro remitente
            	String remitente = "desconocido";
            	if(mensaje.getReplyTo().length >= 1) {
            		remitente = mensaje.getReplyTo()[0].toString();
            	}// Sino cogemos el primer remitente de la lista
            	else if (mensaje.getFrom().length >= 1) {
					remitente = mensaje.getFrom()[0].toString();
				}
            	
            	// Obtenemos el asunto del mensaje
            	String asunto = mensaje.getSubject();
            	System.out.println("Guardando " + asunto + " " + remitente);
            	
            	//Eliminamos caracteres especiales
            	String asuntoSinCaracteresEspeciales = asunto.replaceAll("[^a-zA-Z0-9.-]", "_");
            	asuntoSinCaracteresEspeciales = asuntoSinCaracteresEspeciales.replaceAll("_+", "_");
            	
            	String nombreFichero = CARPETA_DESTINO + asuntoSinCaracteresEspeciales;
            	System.out.println("Nombre del fichero: " + nombreFichero);
            	
            	// llamamos a nuestro metodo de guardar fichero
            	guardaEnFichero(mensaje.getContent(), nombreFichero);
            }
			
		} catch (MessagingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}finally {
			// Cierra los recursos
            if (carpeta != null) carpeta.close(true);
            if (store != null) store.close();
		}
	}
	
	// Método para guardar contenido en un archivo
    public static void guardaEnFichero(Object contenido, String nombreFichero) throws IOException, MessagingException{
    	OutputStream flujoSalida = null;
    	InputStream flujoEntrada = null;
    	
    	try {
    		if(contenido instanceof Multipart) {
    			//Hacemos un cast para obtener los diferentes partes del email
    			Multipart multi = ((Multipart)contenido );
    			int parts = multi.getCount();
    			
    			// Recorremos todas las partes del email
    			for( int i = 0; i < parts; i++) {
    				// Extraemos una parte del email
    				MimeBodyPart parte = (MimeBodyPart)multi.getBodyPart(i);
    				//  Si esta parte tiene más partes hacemos una recursion
    				if(parte.getContent() instanceof Multipart) {
    					guardaEnFichero(parte.getContent(), nombreFichero);
    				}//Si no tiene más partes
    				else {
						String extension = "";
						//Fijamos la extension del fichero segun el tipo de la parte
						if(parte.isMimeType("text/html")) {
							extension = "html";
						}else if (parte.isMimeType("text/plain")) {
							extension = "txt";
						}else {
							// si no sabemos el tipo intentamos obtener la extenson del nombre
								extension = parte.getDataHandler().getName();
						}
						//Añadimos la extensión al fichero
						nombreFichero = nombreFichero + "." + extension;
						System.out.println(".... " + nombreFichero);
						flujoSalida = new FileOutputStream(new File(nombreFichero));
						//Sacamos todo el contenido de la parte del mensaje
						flujoEntrada = parte.getInputStream();
						int j;
						while((j = flujoEntrada.read()) != -1) {
							flujoSalida.write(j);
						}
						
					}
    				
    			}
    		}
    		
    	}finally {
    		// Cierra los recursos
            if (flujoEntrada != null) flujoEntrada.close();
            if (flujoSalida != null) {flujoSalida.flush(); flujoSalida.close();}
    	}
    }

}
