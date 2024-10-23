package com.example.clasesasociadasbotones.menu;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.R;

public class Activity3 extends AppCompatActivity {
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_3);

        //Inicializamos la variable
        ImageView btnBack = findViewById(R.id.btn_back);

        // Damos funcionalidad a la flecha de retorno
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });

        // Funcionalidad del boton
        findViewById(R.id.finish).setOnClickListener(v->finish());

    }
}