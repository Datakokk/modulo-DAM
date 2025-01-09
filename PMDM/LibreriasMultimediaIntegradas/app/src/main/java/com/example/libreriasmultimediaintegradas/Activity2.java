package com.example.libreriasmultimediaintegradas;

import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.VideoView;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

public class Activity2 extends AppCompatActivity {

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_2);
        String url = "https://www.learningcontainer.com/wp-content/uploads/2020/05/sample-mp4-file.mp4";
        Uri urlparse = Uri.parse(url);
        VideoView videoview = findViewById(R.id.videoView);
        videoview.setVideoURI(urlparse);
        Button playbut = findViewById(R.id.btn_play_video);
        Button stopbut = findViewById(R.id.btn_stop_video);

        playbut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                videoview.start();
            }
        });

        stopbut.setOnClickListener(v -> videoview.pause());

    }
}
