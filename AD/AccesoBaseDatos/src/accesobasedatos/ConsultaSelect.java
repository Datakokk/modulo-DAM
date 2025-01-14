package accesobasedatos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class ConsultaSelect {

	// Configuracion de la base de datos
		private static final String DB_URL = "jdbc:mysql://localhost:3306/mi_acceso_datos"; 
		private static final String DB_USER = "root";
		private static final String DB_PASS = "nando";
		
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		consultarProducto();
	}
	
	public static void consultarProducto() {
		String selectQuery = "SELECT * FROM productos";
		
		try(Connection conexion = DriverManager.getConnection(DB_URL,DB_USER,DB_PASS);
			PreparedStatement preparedStatement = conexion.prepareStatement(selectQuery);
			ResultSet resultSet = preparedStatement.executeQuery()	)
		{	
			System.out.println("\nProductos en la Base de Datos:");
			System.out.println("ID | Nombre          | Precio   | Cantidad");
			System.out.println("------------------------------------------");
			
			while(resultSet.next()) {
				int id = resultSet.getInt("id");
				String nombre = resultSet.getString("nombre");
				double precio = resultSet.getDouble("precio");
				int cantidad = resultSet.getInt("cantidad");
			
				System.out.printf("%-3d| %-15s| %-8.2f| %-8d%n", id, nombre, precio, cantidad);
			}
			
		}catch(SQLException e) {
			System.out.println("Error al consultar los productos: " + e.getMessage());
		}
	}

}
