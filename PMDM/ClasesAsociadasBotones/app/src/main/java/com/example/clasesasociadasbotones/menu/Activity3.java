package com.example.clasesasociadasbotones.menu;

import android.os.Bundle;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.R;

public class Activity3 extends AppCompatActivity {
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_3);

        findViewById(R.id.finish).setOnClickListener(v->finish());

    }
}