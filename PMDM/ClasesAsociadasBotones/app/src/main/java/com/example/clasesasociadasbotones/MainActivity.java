package com.example.clasesasociadasbotones;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.menu.*;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        // Botón 1
        Button button1 = findViewById(R.id.button1);
        button1.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, Activity1.class);
            startActivity(intent);
        });
        // Botón 2
        Button button2 = findViewById(R.id.button2);
        button2.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, Activity2.class);
            startActivity(intent);
        });
        // Botón 3
        Button button3 = findViewById(R.id.button3);
        button3.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, Activity3.class);
            startActivity(intent);
        });

        // Botón 4
        Button button4 = findViewById(R.id.button4);
        button4.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, Activity4.class);
            startActivity(intent);
        });
    }
}