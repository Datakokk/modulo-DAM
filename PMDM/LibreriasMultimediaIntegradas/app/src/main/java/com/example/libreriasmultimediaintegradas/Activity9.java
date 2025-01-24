package com.example.libreriasmultimediaintegradas;

import android.media.MediaPlayer;
import android.media.SoundPool;
import android.net.Uri;
import android.os.Bundle;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.VideoView;
import com.bumptech.glide.Glide;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

public class Activity9 extends AppCompatActivity {

    private VideoView videoView;
    private MediaPlayer mediaPlayer;
    private SoundPool soundPool;
    private int soundID;

    private Boolean isAudioPlaying = false;
    private Boolean isSoundPlaying = false;
    private Boolean isVideoAPlaying = false;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_9);

        Button playAudio = findViewById(R.id.btn_play_audio9);
        Button playSound = findViewById(R.id.btn_play_sound9);
        Button playVideo = findViewById(R.id.btn_play_video9);
        Button playGif = findViewById(R.id.btn_show_gif9);
        Button stopGif = findViewById(R.id.btn_hide_gif9);
        Button pauseAudio = findViewById(R.id.btn_stop_audio9);
        Button pauseVideo = findViewById(R.id.btn_stop_video9);
        Button pauseSound = findViewById(R.id.btn_stop_sound9);

        videoView = findViewById(R.id.VideoView9);

        playAudio.setOnClickListener(v -> {
            mediaPlayer = MediaPlayer.create(this, R.raw.audio_file);
            mediaPlayer.start();
            isAudioPlaying = true;
        });

        pauseAudio.setOnClickListener(v -> {
            if(mediaPlayer != null && isAudioPlaying){
                mediaPlayer.pause();
                isAudioPlaying = false;
            }
        });

        soundPool = new SoundPool.Builder().build();
        soundID = soundPool.load(this, R.raw.sound_effect, 1 );

        playSound.setOnClickListener(v-> {
            soundPool.play(soundID, 1, 1, 1, 1, 1);
            isSoundPlaying = true;
        });

        pauseSound.setOnClickListener(v-> {
            if(isSoundPlaying){
                soundPool.stop(soundID);
                isSoundPlaying = false;
            }
        });

        playGif.setOnClickListener(v -> {
            ImageView imageView = findViewById(R.id.imageView9);
            Glide.with(this).load(R.drawable.gif_imagen).into(imageView);
        });

        stopGif.setOnClickListener(v -> {
            ImageView imageView = findViewById(R.id.imageView9);
            imageView.setVisibility(v.GONE); // Oculta la ImageView
        });

        playVideo.setOnClickListener(v -> {
            videoView.setVideoURI(Uri.parse("android.resource://"+getPackageName()+"/"+R.raw.video_file));
            videoView.start();
            isVideoAPlaying = true;
        });

        pauseVideo.setOnClickListener(v->{
            if(isVideoAPlaying){
                videoView.pause();
                isVideoAPlaying = false;
            }
        });
    }
}
