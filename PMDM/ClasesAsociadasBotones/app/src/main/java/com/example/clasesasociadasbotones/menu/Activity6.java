package com.example.clasesasociadasbotones.menu;

import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.R;

public class Activity6 extends AppCompatActivity {

    private TextView tvTimeElapsed;
    private Button btnStart, btnPause, btnReset;
    private Handler handler = new Handler();
    private long startTime = 0;
    private  boolean isRuning = false;
    private long pausedTime = 1000;

    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_6);

        tvTimeElapsed = findViewById(R.id.textViewChonometer);
        btnStart = findViewById(R.id.btn_start);
        btnPause = findViewById(R.id.btn_pause);
        btnReset = findViewById(R.id.btn_reset);

        btnStart.setOnClickListener(v -> {
            startChronometer();
        });

        btnPause.setOnClickListener(v -> {
            pauseChronometer();
        });

        // Estamos utilizando enfoque no lambda para saber que existe.
        btnReset.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                resetChronometer();
            }
        });
    }

    protected  void startChronometer(){
        if(!isRuning){
            startTime = System.currentTimeMillis() - pausedTime;
            handler.post(updateTimeRunnable);//Pone en la cola de ejecucion a updateTimeRunnable
            isRuning = true;
        }
    }

    protected void pauseChronometer(){
        if(isRuning){
            pausedTime = System.currentTimeMillis() - startTime;
            handler.removeCallbacks(updateTimeRunnable);// Retira de la cola de ejecucion a updateTimeRunnable
            isRuning = false;
        }
    }

    protected void resetChronometer(){
        handler.removeCallbacks(updateTimeRunnable);// Retira de la cola de ejecucion a updateTimeRunnable
        startTime = 0;
        pausedTime = 0;
        isRuning = false;
        tvTimeElapsed.setText("00:00");
    }

    // Metodo que se ejecuta cada segundo, debido a que "handler.postDelayed lo pone en la cola de ejecucion cada
    // 1000 milisegundos"
    private Runnable updateTimeRunnable = new Runnable() {
        @Override
        public void run() {
            long elapsedTime = System.currentTimeMillis() - startTime;
            int seconds = (int) (elapsedTime / 1000) % 60;
            int minutes = (int) ((elapsedTime / 1000) / 60);
            String timeFormatted = String.format("%02d:%02d", minutes, seconds);
            tvTimeElapsed.setText(timeFormatted);
            handler.postDelayed(this, 1000); // Actualizar cada segundo
        }
    };

}
