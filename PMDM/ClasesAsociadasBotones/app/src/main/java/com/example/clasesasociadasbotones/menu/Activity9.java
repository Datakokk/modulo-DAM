package com.example.clasesasociadasbotones.menu;

import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.clasesasociadasbotones.R;
import com.example.clasesasociadasbotones.database.DatabaseHelper;

public class Activity9 extends AppCompatActivity {

    EditText etStudentId, etStudentName, etStudentAge;
    Button btnInsert, btnDelete, btnUpdate, btnGet, btnGetAll;
    TextView tvStudentInfo;
    DatabaseHelper dbHelper;

        protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_9);

        // Cambiar el color de la barra de estado solo para esta actividad+
            Window window = getWindow();
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(ContextCompat.getColor(this, android.R.color.holo_blue_light)); // Uso del color predefinido

        // Inicializamos los elementos de la interfaz

        ImageView btnBack = findViewById(R.id.btn_back);

        // Damos funcionalidad a la flecha de retorno
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish(); // Volver a la actividad anterior
            }
        });

        //Inicializamos la base de datos
        dbHelper = new DatabaseHelper(this);

        // Insertar un estudiante


        //Actualizar un studiante


        //Eliminar un estudiante


        // Obtener un estudiante


        // Obtener todos los estudiantes

    }
}
