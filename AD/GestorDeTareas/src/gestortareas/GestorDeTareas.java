package gestortareas;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;

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
		
		String toFileFormat() {
			return description + " ; " + completada;
		}
	};
	
	// Lista para almacenar los tareas
	private static ArrayList<Tarea> tareas = new ArrayList<>();
	private static final String ARCHIVO_TAREAS = "tareas.txt";

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);

	}
	
	// Mostrar Tareas
	private static void mostrarTareas() {
		if(tareas.isEmpty()) {
			System.out.println("No hay tareas en la lista.");
		}else {
			System.out.println("\n --- Lista de Tareas ---");
			for(int i= 0; i < tareas.size(); i++) {
				System.out.println((i + 1) + ". " + tareas.get(i));
			}
		}
	}
	
	// Agregar Tareas
	private static void agregarTareas(Scanner scanner) {
		System.out.println("Ingrese la descripcion de la nueva tarea: ");
		String descripcion = scanner.nextLine();
		tareas.add(new Tarea(descripcion, false));
		System.out.println("Tarea agregada satisfactoriamente");
	}

	// Marcar una tarea como completada
	private static void marcarTareaComoCompletada(Scanner scanner) {
		mostrarTareas();
		if(!tareas.isEmpty()) {
			System.out.println("Ingrese el número de la tarea a marcar como completada: ");
			int indice = scanner.nextInt() - 1;
			
			if(indice >= 0 && indice < tareas.size()) {
				tareas.get(indice).completada = true;
				System.out.println("Tarea como marcada como completada");
			}else {
				System.out.println("Número de tareas no válido.");
			}
		}
	}
	
	// Cargar tareas desde un archivo de texto
	private static void cargarTareasDesdeArchivo() {
		File archivo = new File(ARCHIVO_TAREAS);
		if(!archivo.exists()) {
			System.out.println("No se encontro el archivo de tareas, se creara uno nuevo al guardar.");
			return;
		}
		
		try (BufferedReader br = new BufferedReader(new FileReader(archivo))){
			String linea;
			while((linea = br.readLine()) != null) {
				String[] partes = linea.split(";");
				if(partes.length == 2) {
					String description = partes[0];
					boolean completada = Boolean.parseBoolean(partes[1]);
					tareas.add(new Tarea(description, completada));
				}
			}
			System.out.println("Tareas cargadas desde el archivo");
		} catch (IOException ioe) {
			// TODO: handle exception
			System.out.println("Error al leer el archivos de tareas: " + ioe.getMessage());
		}
	}
	
	// Guardar tareas en un archivo de texto
	private static void guardarTareasEnArchivo() {
		try(BufferedWriter bw = new BufferedWriter(new FileWriter(ARCHIVO_TAREAS))){
			for(Tarea tarea: tareas) {
				bw.write(tarea.toFileFormat());
				bw.newLine();
			}
			System.out.println("Tareas guardadas en el archivo");
		}catch(IOException ioe) {
			System.out.println("Error al guardar las tareas: " + ioe.getMessage());
		}
	}
}
