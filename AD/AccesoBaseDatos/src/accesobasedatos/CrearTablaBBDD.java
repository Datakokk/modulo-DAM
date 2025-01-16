package accesobasedatos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.Scanner;

public class CrearTablaBBDD {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		// Solicitamos el nombre de la tabla
		System.out.println("Itnroduce el nombre de la tabla que deseas crear: ");
		String nombreTabla = sc.nextLine();
		
		// Solicitamos los nombres de los campos y sus tipos
		System.out.println("Ingrese los campos de la tabla (formato: nombreCampo tipoCampo, separados por comas): ");
        System.out.println("Ejemplo: nombre VARCHAR(50), precio DOUBLE, cantidad INT");
		String campos = sc.nextLine();
		
		// Crear la tabla
		crearTabla(nombreTabla, campos);
		
		sc.close();
	}
	
	/**
	 * 
	 * @param nombreTabla
	 * @param campos de la tabla
	 */
	public static void crearTabla(String nombreTabla, String campos) {
		// Realizamos la consulta para crear la tabla
		String crearTablaQuery = "CREATE TABLE " + nombreTabla + "(id INT AUTO_INCREMENT PRIMARY KEY, " + campos + ");";
		
		
		try (
			Connection connection = DriverManager.getConnection(
					ConfiguracionConexionBBDD.getDbUrl(),
					ConfiguracionConexionBBDD.getDbUser(),
				 	ConfiguracionConexionBBDD.getDbPass()
			);
			PreparedStatement preparedStatement = connection.prepareStatement(crearTablaQuery);
		){
			
			// Creamos la tabla al ejecutar la consulta
			preparedStatement.execute();
			System.out.println("Tabla " + nombreTabla + " creado correctamente.");
			
		}catch(SQLException e) {
			System.out.println("Error al crear la tabla " + e.getMessage());
		}
	}

}
