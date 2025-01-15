package com.example.libreriasmultimediaintegradas;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        // Button 1
        Button btnAudio = findViewById(R.id.btn_audio);
        btnAudio.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, Activity1.class);
            startActivity(intent);
        });
        // Button 2
        Button btnVideo = findViewById(R.id.btn_video);
        btnVideo.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, Activity2.class);
            startActivity(intent);
        });
        // Button 3
        Button btnExoplayer = findViewById(R.id.btn_exoplayer);
        btnExoplayer.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, Activity3.class);
            startActivity(intent);
        });

        // Button 4
        Button btnMediaRecorder = findViewById(R.id.btn_media_recorder);
        btnMediaRecorder.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, Activity4.class);
            startActivity(intent);
        });
    }
}