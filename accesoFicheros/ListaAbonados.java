package accesoFicheros;

import java.util.ArrayList;
import java.util.List;

public class ListaAbonados {
	private List<Abonado> lista = new ArrayList<Abonado>();
	
	public ListaAbonados() {}
	
	public void add(Abonado ab) {
		lista.add(ab);
	}
	
	public List<Abonado> getListaAbonados(){
		return lista;
	}
}
