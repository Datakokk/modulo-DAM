package accesobasedatos;



import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.Scanner;

public class CrearProductosBBDD {
	
	// Configuracion de la base de datos
	private static final String DB_URL = "jdbc:mysql://localhost:3306/mi_acceso_datos"; 
	private static final String DB_USER = "root";
	private static final String DB_PASS = "nando";

	public static void main(String[] args) {
		// Scanner para recibir datos
		Scanner sc = new Scanner(System.in);
			
		System.out.println("Insertar un nuevo produlcto en la base de datos");
		
		// Solicitar datos al usuario
		System.out.println("Ingrese el nombre del producto: ");
		String nombre = sc.nextLine();
		
		System.out.println("Ingrese el precio del producto: ");
		Double precio = sc.nextDouble();
		
		System.out.println("Ingrese la cantidad del producto: ");
		int cantidad = sc.nextInt();
		try (Connection connection = DriverManager.getConnection(DB_URL, DB_USER, DB_PASS)) {
		    System.out.println("Conexión establecida exitosamente.");
		} catch (SQLException e) {
		    System.err.println("Error al conectar con la base de datos: " + e.getMessage());
		}
		
		// Llamamos al método para insertar producto
        insertarProducto(nombre, precio, cantidad);

        sc.close();
	}

	/**
	 * Método para ingresar un producto en la tabla productos
	 * @param nombre: Nombre del producto
	 * @param precio: Precio del producto
	 * @param cantidad: cantidad del producto
	 */
	public static void insertarProducto(String nombre, double precio, int cantidad) {
        // Excluimos el campo id de la consulta porque es autoincremental
        String insertQuery = "INSERT INTO productos (nombre, precio, cantidad) VALUES (?, ?, ?)";

        try (Connection connection = DriverManager.getConnection(DB_URL, DB_USER, DB_PASS);
             PreparedStatement preparedStatement = connection.prepareStatement(insertQuery)) {

            // Configurar los parámetros de la consulta
            preparedStatement.setString(1, nombre);
            preparedStatement.setDouble(2, precio);
            preparedStatement.setInt(3, cantidad);

            // Ejecutar la consulta
            int filasAfectadas = preparedStatement.executeUpdate();

            if (filasAfectadas > 0) {
                System.out.println("Producto insertado correctamente.");
            } else {
                System.out.println("Error al insertar el producto.");
            }

        } catch (SQLException e) {
            System.err.println("Error al conectar o insertar en la base de datos: " + e.getMessage());
        }
    }
	
}
