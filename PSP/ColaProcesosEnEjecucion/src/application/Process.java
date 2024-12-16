package application;

public class Process {
	private final int id;
	private final int executionTime; // Tiempo en segundos
	private String state; // "En espera" "En ejecución" "Terminado"
	
	public Process(int id, int executionTime) {
		this.id = id;
		this.executionTime = executionTime;
		this.state = "En espera";
	}

	public String getState() {
		return state;
	}

	public void setState(String state) {
		this.state = state;
	}

	public int getId() {
		return id;
	}

	public int getExecutionTime() {
		return executionTime;
	}
}
