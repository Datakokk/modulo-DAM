package accesoJSON;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.EmptyStackException;
import java.util.HashMap;

import javax.print.attribute.HashAttributeSet;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

public class contadorPalabrasJSON {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String path = "C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\articulo.txt";
		
		HashMap<String, Integer> contarPalabras = new HashMap<>();
		
		// Leemos el fichero
		try {
			BufferedReader br = new BufferedReader(new FileReader(path));
			
			String linea;
			
			while((linea = br.readLine()) != null){
				String[]palabras = linea.toLowerCase().split("\\W+");
				
				for(String palabra : palabras) {
					if(!palabra.isEmpty()) {
						contarPalabras.put(palabra, contarPalabras.getOrDefault(palabra, 0) + 1);
					}
				}
			}
			
		}catch (IOException ioe) {
			// TODO: handle exception
			System.out.println("Error leyendo el archivo : " +ioe.getMessage());
		}
		
		// Convertimos a JSON
		Gson gson = new GsonBuilder().setPrettyPrinting().create();
		String json = gson.toJson(contarPalabras);
		System.out.println(json);
		
		// Guardar el JSON en un archivo
		try {
			
			FileWriter fileJson = new FileWriter("C:\\Users\\tarde\\repositorios\\source\\opt\\alumno\\modulo-DAM\\AD\\articuloJSON.json");
			fileJson.write(json);
            System.out.println("Archivo JSON creado exitosamente.");

		}catch (IOException ioe) {
			// TODO: handle exception
            System.out.println("Error al escribir el archivo JSON: " + ioe.getMessage());

		}
	}

}
