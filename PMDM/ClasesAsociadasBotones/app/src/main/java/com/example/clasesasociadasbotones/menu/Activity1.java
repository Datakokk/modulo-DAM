package com.example.clasesasociadasbotones.menu;

import android.database.Cursor;
import android.os.Build;
import android.os.Bundle;
import android.widget.Button;
import android.view.*;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.clasesasociadasbotones.MainActivity;
import com.example.clasesasociadasbotones.R;
import com.example.clasesasociadasbotones.database.DatabaseHelper;

public class Activity1 extends AppCompatActivity {

    EditText etStudentId, etStudentName, etStudentAge;
    Button btnInsert, btnDelete, btnUpdate, btnGet, btnGetAll;
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
        btnUpdate = findViewById(R.id.btn_update_student);
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
                String name = etStudentName.getText().toString();
                int age = Integer.parseInt(etStudentAge.getText().toString());
                boolean IsInserted = dbHelper.insertStudent(name, age);

                if(IsInserted){
                    Toast.makeText(Activity1.this, "Estudiante insertado", Toast.LENGTH_SHORT).show();
                } else{
                    Toast.makeText(Activity1.this, "Error al insertar estudiante", Toast.LENGTH_SHORT).show();
                }
            }
        });

        btnUpdate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int id = Integer.parseInt(etStudentId.getText().toString());
                String newName = etStudentName.getText().toString();
                int newAge = Integer.parseInt(etStudentAge.getText().toString());
                boolean IsUpdated = dbHelper.updateStudent(id, newName, newAge);

                if(IsUpdated){
                    Toast.makeText(getApplicationContext(), "El alumno se ha actualizado correctamente", Toast.LENGTH_SHORT).show();
                } else {
                    Toast.makeText(getApplicationContext(), "No se actulizado el estudiante", Toast.LENGTH_SHORT).show();
                }
            }
        });

        btnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int id = Integer.parseInt(etStudentId.getText().toString());
                boolean IsDeleted = dbHelper.deleteStudent(id);

                if(IsDeleted){
                    Toast.makeText(Activity1.this, "Se ha borrado el estudiante", Toast.LENGTH_SHORT).show();
                } else{
                    Toast.makeText(Activity1.this, "Error al eliminar al estudiante", Toast.LENGTH_LONG).show();
                }
            }
        });

        btnGet.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int idEstudent = Integer.parseInt(etStudentId.getText().toString());
                Cursor cursor = dbHelper.getStudentById(idEstudent);

                if(cursor != null && cursor.moveToFirst()){
                    String name = cursor.getString(1);
                    int age = cursor.getInt(2);

                    tvStudentInfo.setText("ID: " + idEstudent + ", Nombre: " + name + ", Edad: " + age );
                } else{
                    Toast.makeText(getApplicationContext(), "Estudiante no encontrado", Toast.LENGTH_LONG).show();
                }
            }
        });

        btnGetAll.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String allStudents = dbHelper.getAllStudents();
                tvStudentInfo.setText(allStudents);
            }
        });
    }
}
