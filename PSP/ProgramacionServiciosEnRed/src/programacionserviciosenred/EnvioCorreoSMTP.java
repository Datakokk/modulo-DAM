package programacionserviciosenred;

import javax.mail.PasswordAuthentication;
import java.util.Properties;

import javax.mail.Authenticator;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;

public class EnvioCorreoSMTP {

	public static void main(String[] args) {
		// valores destinatario, asunto y cuerpo
		String destinatario = "fiodorelzarster@gmx.com";
		String asunto = "Correo de prueba enviado desde Java";
		String cuerpo = "Prueba de envio de correo usando java";
		
		enviarConGmail(destinatario, asunto, cuerpo);
		System.out.println("Correo Enviado!!!!");
	}
	
	private static void enviarConGmail(String destinatario, String asunto, String cuerpo) {
		// Direccioon del correo de envio
		String remitente = "fiodorelzarster@gmail.com";
		String claveemail = "qygn cqir aykk rici";
		
		// Propiedades del servidor SMTP
		Properties props = new Properties();
		props.put("mail.smtp.host", "smtp.gmail.com");
		props.put("mail.smtp.port", "587");
		props.put("mail.smtp.auth", "true");
		props.put("mail.smtp.starttls.enable", "true"); // Usamos STARTTLS
		props.put("mail.smtp.ssl.protocols", "TLSv1.2");
		
		// Creamos la sesión
		Session session = Session.getInstance(props, new Authenticator() {
		    @Override
		    protected PasswordAuthentication getPasswordAuthentication() {
		        return new PasswordAuthentication(remitente, claveemail);
		    }
		});
		
		MimeMessage message = new MimeMessage(session);
		
		try {
			message.setFrom(new InternetAddress(remitente));
			message.addRecipient(Message.RecipientType.TO, new InternetAddress(destinatario));
			message.setSubject(asunto);
			message.setText(cuerpo);
			
			//Enviamos el mensaje
			Transport.send(message);
			System.out.println("El correo se ha enviado exitosamente!!!!");
		} catch(MessagingException me) {
			System.err.print("El correo no se ha enviado");
			me.printStackTrace();
		}

	}

}
