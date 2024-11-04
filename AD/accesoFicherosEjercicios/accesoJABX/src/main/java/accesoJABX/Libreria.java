package accesoJABX;

import java.util.ArrayList;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement()
public class Libreria {
	private ArrayList<Libro> listaLibro;
	private String nombre;
	private String lugar;
	
	public Libreria() {}
	
	public void setNombre(String nombre) {this.nombre = nombre; }
	public void setLugar(String lugar) {this.lugar = lugar; }
	
	 


}
