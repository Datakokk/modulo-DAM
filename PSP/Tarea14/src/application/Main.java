package application;
	
import javafx.application.Application;
import javafx.concurrent.Task;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ProgressBar;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.VBox;


public class Main extends Application {
	@Override
	public void start(Stage primaryStage) {
		Button startButton = new Button("Iniciar tarea");
		ProgressBar progressBar = new ProgressBar(0);
		Label statusLabel = new Label("Estado: Listo");
		
		//Configuracion inicial
		progressBar.setPrefWidth(300);
		
		startButton.setOnAction(event-> {
			Task<Void> task = new Task<>() {

				@Override
				protected Void call() throws Exception {
					// TODO Auto-generated method stub
					for(int i=0; i<= 100; i++) {
						Thread.sleep(50);// Se simula una operación costosa
						updateProgress(i, 100); // Actualiza el progreso
						updateMessage("Progreso: "+ i + "%"); //Actualiza el mensaje
					}
					return null;
				}
			};
			
			// Vincular propiedades de la tarea con la interfaz
			progressBar.progressProperty().bind(task.progressProperty());
			statusLabel.textProperty().bind(task.messageProperty());
			
			// Manejar eventos de finalización 
			task.setOnSucceeded(e-> {
				statusLabel.textProperty().unbind();
				statusLabel.setText("Estado: Tarea completada");
			});
			
			task.setOnFailed(e->{
				statusLabel.textProperty().unbind();
				statusLabel.setText("Estado: Error en la tarea");
			});
			
			// Iniciar la tarea en un nuevo hilo
			new Thread(task).start();
		});
		
		VBox root = new VBox(10, startButton, progressBar, statusLabel);
		root.setStyle("-fx-padding: 20; -fx-alignment: center; -fx-spacing: 10;");
		
		primaryStage.setScene(new Scene(root, 400, 200));
		primaryStage.setTitle("Ejemplo de Hilos en JavaFX");
		primaryStage.show();
	}
	
	public static void main(String[] args) {
		launch(args);
	}
}
