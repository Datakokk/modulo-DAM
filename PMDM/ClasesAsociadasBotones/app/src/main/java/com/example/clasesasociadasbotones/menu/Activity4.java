package com.example.clasesasociadasbotones.menu;

import android.os.Build;
import android.os.Bundle;
import android.widget.Button;
import android.view.*;

import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.R;

public class Activity4 extends AppCompatActivity {

    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_4);

        // Cambiar el color de la barra de estado solo para esta actividad
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            Window window = getWindow();
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(getResources().getColor(android.R.color.holo_blue_light)); // Uso del color predefinido
        }
    }
}
