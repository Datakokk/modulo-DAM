package accesoFicheros;

public class Abonado {
	private String nombre;
	private String telefono; 

	public Abonado(String nombre, String telefono) {
		this.nombre = nombre;
		this.telefono = telefono;
	}
	public Abonado() {
		this.nombre=null;
	}
	public void setNombre(String nom) {nombre=nom;}
	public void setTfno(String tf) {telefono=tf;}
	
	public String getNombre() {return nombre;} 
	public String getTfno() {return telefono;}
}



