package com.example.clasesasociadasbotones.menu;

import android.content.Intent;
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
            EditText etInputID = findViewById(R.id.et_admin);
            Button btnAdmin = findViewById(R.id.btn_admin);
            Button btnUser = findViewById(R.id.btn_user);
            ImageView btnBack = findViewById(R.id.btn_back);

        // Damos funcionalidad a la flecha de retorno
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish(); // Volver a la actividad anterior
            }
        });

       // Ingresamos como administrador
            btnAdmin.setOnClickListener(v -> {
                if (!etInputID.getText().toString().equals("admin")){
                    Toast.makeText(Activity9.this, "La contraseña no es correcta", Toast.LENGTH_LONG).show();
                }else{
                    Intent intent = new Intent(Activity9.this, ActivityAdmin.class);
                    startActivity(intent);
                }
                etInputID.getText().clear();
           });

        //Ingresamos como usuario
            btnUser.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent intent = new Intent(Activity9.this, ActivityUser.class);
                    startActivity(intent);
                }
            });

    }
}
