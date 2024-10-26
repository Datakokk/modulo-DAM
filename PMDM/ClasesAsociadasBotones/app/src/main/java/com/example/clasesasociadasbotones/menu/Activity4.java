package com.example.clasesasociadasbotones.menu;

import android.content.Context;
import android.os.Bundle;
import android.widget.Button;
import android.view.*;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.clasesasociadasbotones.R;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class Activity4 extends AppCompatActivity {

    private EditText editTextNombreArchivo;
    private EditText editTextContenidoArchivo;
    private Button buttonEscribirArchivo;
    private Button buttonMostrarArchivo;
    private TextView textViewContenidoArchivo;
    private ImageView btnBack;


    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_4);

        // Inicializamos las variables
        buttonEscribirArchivo = findViewById(R.id.button_Escribir);
        buttonMostrarArchivo = findViewById(R.id.button_Mostrar);
        editTextNombreArchivo = findViewById(R.id.EditTextNombreArchivo);// Buscar esto EditTextNombreArchivo
        editTextContenidoArchivo = findViewById(R.id.EditTextContenidoArchivo);// Buscar esto
        btnBack = findViewById(R.id.btn_back);

        // Damos funcionalidad a la flecha de regreso
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });

        buttonMostrarArchivo.setOnClickListener(v->{
            String nombre_archivo = editTextNombreArchivo.getText().toString();
            if(nombre_archivo.isEmpty()){
                Toast.makeText(this, "Por favor introduce el nombre", Toast.LENGTH_LONG).show();
            }else{
                mostrar_contenido(nombre_archivo);
            }
        });

        buttonEscribirArchivo.setOnClickListener(v->{
            String nombre_archivo = editTextNombreArchivo.getText().toString();
            String contenido_archivo = editTextContenidoArchivo.getText().toString();
            if(nombre_archivo.isEmpty()){
                Toast.makeText(this, "Por favor introduce datos", Toast.LENGTH_LONG).show();
            }else{
                escribirArchivo(nombre_archivo, contenido_archivo);
            }
        });


        // Cambiar el color de la barra de estado solo para esta actividad
        Window window = getWindow();
        window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
        window.setStatusBarColor(ContextCompat.getColor(this, android.R.color.holo_blue_light)); // Uso del color predefinido
    }

    private void mostrar_contenido(String nombre_archivo){
        textViewContenidoArchivo = findViewById(R.id.textViewArchivos);
        String contenido_archivo = leer_archivo(nombre_archivo);
        if(nombre_archivo != null)
        {
            textViewContenidoArchivo.setText(contenido_archivo);
        }else{
            Toast.makeText(this, "No hay ningun archivo en la mamoria", Toast.LENGTH_LONG).show();
        }
    }

    private  String leer_archivo(String nombre_archivo){
        FileInputStream fis = null;
        try{
            fis = openFileInput(nombre_archivo);
            StringBuilder stringBuilder = new StringBuilder();
            int i;
            while((i=fis.read()) != -1){
                stringBuilder.append((char) i);
            }
            return stringBuilder.toString();
        }catch(IOException e){
            e.printStackTrace();
            return "No ha funcionado";
        }
        finally {
           if(fis != null){
               try{
                   fis.close();
               }catch (IOException e){
                   e.printStackTrace();
               }
           }
        }
    }

    private void escribirArchivo(String nombre_archivo, String texto){
        FileOutputStream fos = null;
        try{
            fos = openFileOutput(nombre_archivo, Context.MODE_PRIVATE);
            Toast.makeText(this, "Cargado con exito", Toast.LENGTH_LONG).show();
            fos.write(texto.getBytes());
        }catch(IOException e){
            e.printStackTrace();
        }finally {
            if(fos != null){
                try{
                    fos.close();
                }catch(IOException e){
                    e.printStackTrace();
                }
            }
        }
    }
}
