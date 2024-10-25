package com.example.clasesasociadasbotones.menu;

import android.content.Context;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.clasesasociadasbotones.R;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class Activity5 extends AppCompatActivity {

    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_5);

        Button botonCarga = findViewById(R.id.buttonAddStudents);
        Button botonComprobar = findViewById(R.id.buttonAddStudentsJ);
        LinearLayout container = findViewById(R.id.main_Layout);
        EditText editTextStudentJ = findViewById(R.id.editTextStudentsJ);

        botonCarga.setOnClickListener(v -> {
            String input = editTextStudentJ.getText().toString();
            for(int i=0; i<=Integer.valueOf(editTextStudentJ.getText().toString()); i++){
                TextView view = new TextView(Activity5.this);
                view.setText("Student " + i);
                view.setPadding(8, 8, 8, 8);
                view.setTextSize(16);
                container.addView(view);
            }
        });

        botonComprobar.setOnClickListener(v -> {
            findViewStudentsByText("Student");
          });
    }

    private void findViewStudentsByText(String studentText){
        LinearLayout container = findViewById(R.id.main_Layout);
        for (int i=0; i<container.getChildCount(); i++){
            View view = container.getChildAt(i);
            if(view instanceof TextView){
                TextView textView = (TextView) view;
                if(textView.getText().toString().contains(studentText)){
                    textView.setText(textView.getText().toString() + " (encontrado)");
                    textView.setTextColor(getResources().getColor(android.R.color.holo_red_dark));
                }
            }
        }
    }
}
