package com.example.clasesasociadasbotones.menu;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.R;

public class Activity2 extends AppCompatActivity {
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_2);

        // Inicializamos los elementos de la interfaz
        EditText editTextName = findViewById(R.id.editTextName);
        Button buttonSaveName = findViewById(R.id.buttonSave);
        Button buttonShowName = findViewById(R.id.showName);
        TextView textViewName = findViewById(R.id.TextViewName);
        ImageView btnBack = findViewById(R.id.btn_back);

        SharedPreferences sharedPreferences = getSharedPreferences("MyPref", MODE_PRIVATE);
        String savedName = sharedPreferences.getString("name", "No none saved");
        //textViewName.setText(savedName);

        // Damos funcionalidad a la flecha de retorno
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish(); //Volver a la actividad anterior
            }
        });

        buttonSaveName.setOnClickListener( v -> {
            String newName = editTextName.getText().toString();
                SharedPreferences.Editor editor = sharedPreferences.edit();
                editor.putString("name", newName);
                editor.apply();

                //textViewName.setText(newName);
        });

        buttonShowName.setOnClickListener( v -> {
            String name = sharedPreferences.getString("name", "EL nombre no se ha encontrado");

            textViewName.setText("El nombre es: " + name);
        });
    }
}
