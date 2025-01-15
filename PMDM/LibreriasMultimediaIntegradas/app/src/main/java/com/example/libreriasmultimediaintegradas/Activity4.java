package com.example.libreriasmultimediaintegradas;

import android.content.pm.PackageManager;
import android.media.MediaPlayer;
import android.media.MediaRecorder;
import android.os.Bundle;
import android.widget.Button;
import android.widget.Toast;
import android.Manifest;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import java.io.File;
import java.io.IOException;

public class Activity4 extends AppCompatActivity {

    private MediaRecorder grabacion;
    private String archivoSalida;
    private Button btnStartRecording;
    private Button btnStopRecording;
    private Button btnPlayrecording;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_4);

        btnStartRecording = findViewById(R.id.btn_start_recording);
        btnStopRecording = findViewById(R.id.btn_stop_recording);
        btnPlayrecording = findViewById(R.id.btn_play_recording);

        // Desactivar los botones de play y stop
        btnPlayrecording.setEnabled(false);
        btnStopRecording.setEnabled(false);

        //  Verificamos y soliicitamos los permisos
        if(!checkPermissions()){
            requestPermissions();
        }

        File dir = getFilesDir();
        archivoSalida = new File(dir, "archivo_salida.3gp").getAbsolutePath();
    }

    private boolean checkPermissions() {
        return ContextCompat.checkSelfPermission(this, Manifest.permission.WRITE_EXTERNAL_STORAGE) == PackageManager.PERMISSION_GRANTED &&
                ContextCompat.checkSelfPermission(this, Manifest.permission.RECORD_AUDIO) == PackageManager.PERMISSION_GRANTED;
    }

    private void requestPermissions() {
        ActivityCompat.requestPermissions( this, new String[]{
                Manifest.permission.WRITE_EXTERNAL_STORAGE,
                Manifest.permission.RECORD_AUDIO
        }, 1000);
    }

    public void play_record() throws IOException {
        grabacion = new MediaRecorder();
        grabacion.setAudioSource(MediaRecorder.AudioSource.MIC);
        grabacion.setOutputFormat((MediaRecorder.OutputFormat.THREE_GPP));
        grabacion.setAudioEncoder(MediaRecorder.AudioEncoder.AMR_NB);
        grabacion.setOutputFile(archivoSalida);

        grabacion.prepare();
        grabacion.start();

        btnStartRecording.setEnabled(false);
        btnStopRecording.setEnabled(true);
        btnPlayrecording.setEnabled(false);

        Toast.makeText(this, "Grabando", Toast.LENGTH_SHORT).show();
    }
    public void stop_record(){
        try{
            grabacion.stop();
            grabacion.release();
            grabacion = null;

            btnStartRecording.setEnabled(true);
            btnStopRecording.setEnabled(false);
            btnPlayrecording.setEnabled(true);
        }catch (RuntimeException e){
            Toast.makeText(this, "Error al obtener la grabación", Toast.LENGTH_SHORT).show();
        }
    }
    public void play_recording(){
        MediaPlayer mediaPlayer = new MediaPlayer();
        try {
            mediaPlayer.setDataSource(archivoSalida);
            mediaPlayer.prepare();
            mediaPlayer.start();
            Toast.makeText(this, "Reproduciendo sonido", Toast.LENGTH_SHORT).show();

            mediaPlayer.setOnCompletionListener(mp -> {
                mediaPlayer.release();
                Toast.makeText(this, "Reproducción finalizada", Toast.LENGTH_SHORT).show();
            });
        }catch (IOException e){
            Toast.makeText(this, "Error al reproducir el audio", Toast.LENGTH_SHORT).show();
        }
    }
}
