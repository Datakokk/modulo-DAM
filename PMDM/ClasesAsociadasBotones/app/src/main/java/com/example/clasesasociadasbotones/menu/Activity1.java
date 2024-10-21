package com.example.clasesasociadasbotones.menu;

import android.os.Build;
import android.os.Bundle;
import android.widget.Button;
import android.view.*;
import android.widget.EditText;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.clasesasociadasbotones.R;
import com.example.clasesasociadasbotones.database.DatabaseHelper;

public class Activity1 extends AppCompatActivity {

    EditText etStudentId, etStudentName, etStudentAge;
    Button btnInsert, btnDelete, btnGet, btnGetAll;
    TextView tvStudentInfo;
    DatabaseHelper dbHelper;

    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_1);

        // Cambiar el color de la barra de estado solo para esta actividad
            Window window = getWindow();
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(ContextCompat.getColor(this, android.R.color.holo_blue_light)); // Uso del color predefinido

        // Inicializamos los elementos de la interfaz
        etStudentAge = findViewById(R.id.et_student_age);
        etStudentId = findViewById(R.id.et_student_id);
        etStudentName = findViewById(R.id.et_student_name);
        btnInsert = findViewById(R.id.btn_insert_student);
        btnGet = findViewById(R.id.btn_get_student);
        btnGetAll = findViewById(R.id.btn_all_students);
        btnDelete = findViewById(R.id.btn_delete_student);
        tvStudentInfo = findViewById(R.id.tv_info_student);

        //Inicializamos la base de datos
        dbHelper = new DatabaseHelper(this);

        // Insertar un estudiante
        btnInsert.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

            }
        });
    }
}
