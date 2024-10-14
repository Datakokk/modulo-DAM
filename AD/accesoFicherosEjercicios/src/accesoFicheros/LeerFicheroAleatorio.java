package accesoFicheros;
import java.io.*;

public class LeerFicheroAleatorio {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\accesoFicheros\\";
		File fichero = new File(path + "AleatorioEmple.txt");
		
		//TO
		RandomAccessFile file = new RandomAccessFile(fichero, "r");
	
		int id, dep, posicion;
		Double salario;
		char apellido[] = new char[10];
		
		posicion=0;
		
		 while(true){
			file.seek(posicion);
			id=file.readInt(); // Leemos el id de empleado
			for (int i=0;i<apellido.length;i++)
				apellido[i]=file.readChar(); // Leemos el apellido String apellidoS=new String(apellido);
			String apellidoS = new String(apellido);
			dep=file.readInt(); // Leemos el departamento
			salario=file.readDouble(); // Leemos el sueldo (8 bytes)System.out.println("ID empleado: "+id+"- Apellido:"+apellidoS+"- Depto "+dep+"- Salario: "'+salario);
			System.out.println("ID empleado: " + id + " - Apellido: " + apellidoS );
			posicion=posicion+36;
			if (file.getFilePointer()==file.length())break;
			file.close();
		 }
	}

}
