package com.example.libreriasmultimediaintegradas;

import android.media.AudioManager;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;


import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import java.net.URI;

public class Activity1 extends AppCompatActivity {
    private MediaPlayer mediaPlayer;
    private AudioManager audioManager;
    String audioUrl = "https://www.soundhelix.com/examples/mp3/SoundHelix-Song-1.mp3";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_1);

        audioManager = (AudioManager) getSystemService(AUDIO_SERVICE);
        Button playbut = findViewById(R.id.btn_play_audio);
        Button stopbut = findViewById(R.id.btn_stop_audio);
        Button btnSilence = findViewById(R.id.btn_mute_audio);
        Button btnIncrease = findViewById(R.id.btn_increase_volume);
        Button btnDecrease = findViewById(R.id.btn_decrease_volume);
        Uri parseUri = Uri.parse(audioUrl);
        mediaPlayer = MediaPlayer.create(this, parseUri);

        playbut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                playAudio();
            }
        });

        stopbut.setOnClickListener(v -> {
            mediaPlayer.stop();
        });

        btnIncrease.setOnClickListener(v -> {
            audioManager.adjustVolume(AudioManager.ADJUST_RAISE, AudioManager.FLAG_SHOW_UI);
        });
        btnDecrease.setOnClickListener(v -> {
            audioManager.adjustVolume(AudioManager.ADJUST_LOWER, AudioManager.FLAG_SHOW_UI);
        });
        btnSilence.setOnClickListener(v-> {
            audioManager.adjustVolume(AudioManager.ADJUST_MUTE, AudioManager.FLAG_SHOW_UI);
        });
    }

    private void playAudio() {
        if (mediaPlayer != null) {
            mediaPlayer.stop();
            mediaPlayer.release();
        }

        mediaPlayer = new MediaPlayer();
        try {
            mediaPlayer.setDataSource(audioUrl);
            mediaPlayer.prepareAsync(); // Prepare de forma asíncrona para evitar bloquear el hilo principal
            mediaPlayer.setOnPreparedListener(mp -> {
                mediaPlayer.start();
                Toast.makeText(this, "Reproduciendo audio", Toast.LENGTH_SHORT).show();
            });
            mediaPlayer.setOnErrorListener((mp, what, extra) -> {
                Toast.makeText(this, "Error al reproducir el audio", Toast.LENGTH_SHORT).show();
                return true;
            });
        } catch (Exception e) {
            e.printStackTrace();
            Toast.makeText(this, "Error: " + e.getMessage(), Toast.LENGTH_LONG).show();
        }
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        if (mediaPlayer != null) {
            mediaPlayer.release();
            mediaPlayer = null;
        }
    }
}
