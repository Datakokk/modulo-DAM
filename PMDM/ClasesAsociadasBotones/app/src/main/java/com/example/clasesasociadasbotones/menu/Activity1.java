package com.example.clasesasociadasbotones.menu;

import android.os.Build;
import android.os.Bundle;
import android.widget.Button;
import android.view.*;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.clasesasociadasbotones.R;

public class Activity1 extends AppCompatActivity {

    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_1);

        // Cambiar el color de la barra de estado solo para esta actividad
            Window window = getWindow();
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(ContextCompat.getColor(this, android.R.color.holo_blue_light)); // Uso del color predefinido

    }
}
