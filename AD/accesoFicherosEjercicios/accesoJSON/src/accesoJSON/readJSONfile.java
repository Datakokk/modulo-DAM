package accesoJSON;
import com.google.gson.Gson;
import java.io.*;

public class readJSONfile {

    public static void main(String[] args) {

    	BufferedReader in=null;
		try {
			in = new BufferedReader(new FileReader("Seleccion.json"));
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
    	StringBuilder lineas = new StringBuilder();
    	String linea;
		try {
			while ((linea=in.readLine()) != null)
			{
				lineas.append(linea);
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
    	
        Gson gson = new Gson();
        FootballPlayer[] footballPlayers = gson.fromJson(lineas.toString(),
                FootballPlayer[].class);

        for (FootballPlayer footballPlayer : footballPlayers) {
            System.out.println(footballPlayer);
        }
    }
}