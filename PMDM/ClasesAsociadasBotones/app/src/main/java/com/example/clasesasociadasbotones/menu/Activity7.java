package com.example.clasesasociadasbotones.menu;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.R;

public class Activity7 extends AppCompatActivity {
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_7);

        TextView tv_metersToKm = findViewById(R.id.tv_meters_to_km);
        TextView tv_celsiusToFahrenheit = findViewById(R.id.tv_celsius_to_fahrenheit);
        Button btn_meterToKm = findViewById(R.id.btn_meters_to_KM);
        Button btn_celsiusToFahrenheit = findViewById(R.id.btn_celsius_to_Fahrenheit);
        EditText et_metersToKm = findViewById(R.id.et_input_meters);
        EditText et_celsiudToFahrenheit = findViewById(R.id.et_input_celsius);

        //Inicializamos la variable
        ImageView btnBack = findViewById(R.id.btn_back);

        // Damos funcionalidad a la flecha de retorno
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });

        // Boton que convierte metros a K, mostrando el resultado en TextView
        btn_meterToKm.setOnClickListener(v -> {
            String value = et_metersToKm.getText().toString();
            if(!value.isEmpty()){
                String result = MetersToKm(Double.parseDouble(value));
                tv_metersToKm.setText(result+" Km");
            }else {
                tv_metersToKm.setText("Por favor, ingresa números válidos");
            }

        });

        // Boton que convierte °C a °F, mostrando el resultado en TextView
        btn_celsiusToFahrenheit.setOnClickListener(v -> {
            String value = et_celsiudToFahrenheit.getText().toString();
            if(!value.isEmpty()) {
                String result = CelsiusToFahrenheit(Double.parseDouble(value));
                tv_celsiusToFahrenheit.setText(result + " °F");
            }else {
                tv_celsiusToFahrenheit.setText("Ingrese un número valido");
            }
        });
    }

    // Convierte metros a Km - devuelve un string
    protected String MetersToKm(double meters){
        return String.valueOf(meters/1000);
    }

    // Convierte celsius a Fahrenheit
    protected String CelsiusToFahrenheit(double celsius){
        return String.valueOf((celsius * 9/5)+ 32);
    }
}