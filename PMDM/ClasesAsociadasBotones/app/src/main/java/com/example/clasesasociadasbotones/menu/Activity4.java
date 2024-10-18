package com.example.clasesasociadasbotones.menu;

import android.content.Context;
import android.os.Build;
import android.os.Bundle;
import android.widget.Button;
import android.view.*;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.R;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class Activity4 extends AppCompatActivity {

    private EditText editTextNombreArchivo;
    private EditText editTextContenidoArchivo;
    private Button buttonEscribirARchivo;
    private Button buttonMostrarArchivo;
    private TextView textViewContenidoArchivo;


    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_4);

        buttonEscribirARchivo = findViewById(R.id.button_Escribir);// Crear este boton
        buttonMostrarArchivo = findViewById(R.id.button_Mostrar);
        editTextNombreArchivo = findViewById(R.id.editTextNomvreArchivo);// Buscar esto
        editTextContenidoArchivo = findViewById(R.id.editTextContenidoArchivo);// Buscar esto

        buttonMostrarArchivo.setOnClickListener(v->{
            String contenido = editTextContenidoArchivo.getText().toString();
            if(nombre_archivo.isEmpty()){
                Toast.makeText(this, "Por favor introduce el nombre", Toast.LENGTH_LONG).show();
            }else{
                mostrar_contenido(nombre_archivo);
            }
        });

        buttonCrearArchivo.setOnClickListener(v->{
            String nombre_archivo = editTextNombreArchivo.getText().toString();
            String contenido_archivo = editTextContenidoArchivo.getText().toString();
            if(nombre_archivo.isEmpty()){
                Toast.makeText(this, "Por favor introudce datos", Toast.LENGTH_LONG).show();
            }else{
                escribirArchivo(nombre_archivo, contenido_archivo);
            }
        });


        // Cambiar el color de la barra de estado solo para esta actividad
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            Window window = getWindow();
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(getResources().getColor(android.R.color.holo_blue_light)); // Uso del color predefinido
        }
    }

    private void mostrar_contenido(String nombre_archivo){
        textViewContenidoArchivo = findViewById(R.id.textViewArchivos);
        String contenido_archivo = leer_archivo(nombre_archivo);
        if(nombre_archivo != null)
        {
            textViewContenidoArchivo.setText(contenido_archivo);
        }else{
            Toast.makeText(this, "No hay ningun archivo en la mamoria", Toast.LENGTH_LONG).show()
        }
    }

    private  String leer_archivo(String nombre_archivo){
        FileInputStream fis = null;
        try{
            fis = openFileInput(nombre_archivo);
            StringBuilder stringBuilder = new StringBuilder();
            int i;
            while((i=fis.read()) != -1){
                stringBuilder.append((char), i);
            }
        }catch(IOException e){

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

    private void escribirArchivo(String nombre_archivo, String contenido){
        FileOutputStream fos = null;
        try{
            fos = openFileOutput(nombre_archivo, Context.MODE_PRIVATE);
            Toast.makeText(this, "Cargado con exito");
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
