package com.example.clasesasociadasbotones.menu;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.example.clasesasociadasbotones.R;

import java.util.ArrayList;

public class Activity8 extends AppCompatActivity {
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_8);

        //Inicializamos la variable
        ImageView btnBack = findViewById(R.id.btn_back);
        EditText etInputNots = findViewById(R.id.et_input_note);
        Button btnAddNote = findViewById(R.id.btn_add_note);
        ListView lvShowNotes = findViewById(R.id.lv_show_notes);

        ArrayList<String> notesList = new ArrayList<>();
        // ArrayAdapter actua como un intermediario entre una fuente de datos y un interfaz visual
        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, notesList);
        lvShowNotes.setAdapter(adapter);
        // Funcionalidad de la flecha de retorno
        btnBack.setOnClickListener(v -> { finish();});

        // Introducir Nota
        btnAddNote.setOnClickListener(v -> {
            String value = etInputNots.getText().toString();
            if(!value.isEmpty()){
                notesList.add(value);
                adapter.notifyDataSetChanged();
                etInputNots.setText("");
            }
        });

        lvShowNotes.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                notesList.remove(position);
                adapter.notifyDataSetChanged();
            }
        });
    }

}