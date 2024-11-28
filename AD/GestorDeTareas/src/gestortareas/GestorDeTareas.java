package gestortareas;

public class GestorDeTareas {
	
	static class Tarea {
		String description;
		boolean completada;
		
		public Tarea(String description, boolean completada) {
			// TODO Auto-generated constructor stub
			this.description = description;
			this.completada = completada;
		}
		
		public String toString() {
			return (completada ? "[X]" : "[ ]") + description;
		}
	};

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
