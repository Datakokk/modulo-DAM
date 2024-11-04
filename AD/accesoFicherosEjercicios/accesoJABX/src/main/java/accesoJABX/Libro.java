package accesoJABX;
import javax.xml.bind.annotation.XmlType;

@XmlType(propOrder = {"nombre", "autor", "editorial", "isbn"}) 
public class Libro {
	private String nombre;
	private String autor;
	private String editorial;
	private String isbn;
	
	public Libro(String nombre, String autor, String editorial, String isbn) {
		super();
		this.nombre = nombre;
		this.autor = autor;
		this.editorial = editorial;
		this.isbn = isbn;
	}
	
	public Libro() {}
	
	public String getNombre() {return nombre;}
	public String getAutor() {return autor;}
	public String getEditorial() {return editorial;}
	public String getIsbn() {return isbn;}
	
	
	public String setNombre(String nombre) {return this.nombre=nombre;}
	public String setAutor(String autor) {return this.autor = autor;}
	public String setEditorial(String editorial) {return this.editorial = editorial;}
	public String setIsbn(String isbn) {return this.isbn = isbn;}
	
}
