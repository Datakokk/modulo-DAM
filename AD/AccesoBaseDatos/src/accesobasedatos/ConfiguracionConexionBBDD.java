package accesobasedatos;

public class ConfiguracionConexionBBDD {
	// Configuración de la base de datos
    private static final String DB_URL = "jdbc:mysql://localhost:3306/mi_acceso_datos"; 
    private static final String DB_USER = "root";
    private static final String DB_PASS = "nando";
    
    public static String getDbUrl() {
    	return DB_URL;
    }
    
    public static String getDbUser() {
    	return DB_USER;
    }
    
    public static String getDbPass() {
		return DB_PASS;
	}
}
