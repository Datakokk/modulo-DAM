package application;
	
import java.util.ArrayList;
import java.util.List;

import javafx.application.Application;
import javafx.beans.property.SimpleDoubleProperty;
import javafx.beans.property.SimpleStringProperty;
import javafx.concurrent.Task;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.chart.LineChart;
import javafx.scene.chart.NumberAxis;
import javafx.scene.chart.XYChart;
import javafx.scene.control.Button;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.VBox;


public class Main extends Application {
	
	private Task<Void>marketTask;
	private Thread marketThread;
	private List<Stock> stocks = new ArrayList<>();
	@Override
	public void start(Stage primaryStage) {
		
		// Crear una tabla para mostrar las acciones
		TableView<Stock> table = new TableView<>();
		
		TableColumn<Stock, String> nameColumn = new TableColumn<>("Acción");
		nameColumn.setCellValueFactory(data -> new SimpleStringProperty(data.getValue().getName()));
		
		TableColumn <Stock, Double>valueColumn = new TableColumn<>("Valor");
		valueColumn.setCellValueFactory(data -> new SimpleDoubleProperty(data.getValue().getValue()).asObject());
		
		table.getColumns().add(nameColumn);
		table.getColumns().add(valueColumn);
		
		// Creamos la lista de acciones
		stocks.add(new Stock("XOM", 113.57	));
		stocks.add(new Stock("CVX", 155.24));
		stocks.add(new Stock("BP", 28.70));
		stocks.add(new Stock("COP", 103.22));
		stocks.add(new Stock("EQNR", 24.10));
		table.getItems().addAll(stocks);
		
		//Boton que pausa y reanudad actualizaciones
		Button pauseBoton = new Button("Iniciar");
		pauseBoton.setOnAction(event-> {
			if(marketTask != null && !marketTask.isCancelled()) {
				marketTask.cancel();
				marketThread.interrupt();
				pauseBoton.setText("Reanudar");
			} else {
				startMarketTask(table);
				pauseBoton.setText("Pausar");
			}
		});
		
		//Vamos a crear los ejes X e Y para el gráfico
		NumberAxis xAxis = new NumberAxis();
		NumberAxis yAxis = new NumberAxis();
				
		LineChart<Number, Number> lineChart = new LineChart<>(xAxis, yAxis);
		lineChart.setTitle("Simulador de Mercado Bursátil");
				
		//Creamos serie de  datos a introducir en la tabla
		XYChart.Series<Number, Number>serie = new XYChart.Series<>();
		serie.setName("Valor de Acción");
				
		// Agregar datos al gráfico
		for(int i=0; i<10; i++) {
			serie.getData().add(new XYChart.Data<>(i, Math.random() * 200));
		}
				
		lineChart.getData().add(serie);
		
		//Mostramos los elementos tabla y button
		VBox vbox = new VBox(table, pauseBoton);
		Scene scene = new Scene(vbox, 600, 400);
		
		// Creamos layout y escena
		//VBox vbox = new VBox(lineChart);
		//Scene scene = new Scene(vbox, 600, 400);
		
		primaryStage.setTitle("Simulador de Mercado Búrsatil");
		primaryStage.setScene(scene);
		primaryStage.show();
   	}
	
	private void startMarketTask(TableView<Stock>table) {
		marketTask = new MarketTask(table, stocks);
		marketThread = new Thread(marketTask);
		marketThread.setDaemon(true);
		marketThread.start();
	}
	
	public static void main(String[] args) {
		launch(args);
	}
}
