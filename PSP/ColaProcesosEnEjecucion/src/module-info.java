module ColaProcesosEnEjecucion {
    requires javafx.controls;
    requires javafx.fxml; // Si usas FXML, mantén esto
    exports application; // Permite que otros módulos accedan públicamente
    opens application to javafx.base; // Permite el acceso reflexivo a JavaFX
}
