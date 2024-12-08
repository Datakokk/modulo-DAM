package application;

import java.util.List;
import java.util.Random;

import javafx.concurrent.Task;
import javafx.scene.control.TableView;

public class MarketTask extends Task<Void>{
 	private final TableView<Stock> table;
	private final List<Stock> stocks;
	
	public MarketTask(TableView<Stock> table, List<Stock> stocks) {
		this.table = table;
		this.stocks = stocks;
	}

	@Override
	protected Void call() throws Exception {
		// TODO Auto-generated method stub
		Random random = new Random();
		
		while(!isCancelled()) {
			// Se actualiza los valores de las acciones
			for(Stock stock: stocks) {
				double newValue = 100 + random.nextDouble() * 200;
				stock.setValue(newValue);
			}
			
			// Se refresca la tabla en el hilo de la interfaz gráfica
			javafx.application.Platform.runLater(() -> table.refresh());
			
			// Se da un segundo de pausa entre actualizaciones.
			Thread.sleep(1000);
		}
		return null;
	}
}
