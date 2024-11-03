package com.example.clasesasociadasbotones.menu;

import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.clasesasociadasbotones.R;
import com.example.clasesasociadasbotones.database.DatabaseTrivia;

public class ActivityAdmin extends AppCompatActivity {

    EditText etQuestion, etAnswer2, etAnswer1, etAnswer3, etRigthAnswer;
    Button btnAddQuestion;
    ImageView btnBack;
    DatabaseTrivia dbTrivia;

        protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin);

        // Cambiar el color de la barra de estado solo para esta actividad+
            Window window = getWindow();
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(ContextCompat.getColor(this, android.R.color.holo_blue_light)); // Uso del color predefinido

            // Inicializamos la base de datos
            dbTrivia = new DatabaseTrivia(this);

        // Inicializamos los elementos de la interfaz
            etQuestion = findViewById(R.id.et_question);
            etAnswer2 = findViewById(R.id.et_answer2);
            etAnswer1 = findViewById(R.id.et_answer1);
            etAnswer3 = findViewById(R.id.et_answer3);
            etRigthAnswer = findViewById(R.id.et_right_answer);
            btnAddQuestion = findViewById(R.id.btn_add_question);
            btnBack = findViewById(R.id.btn_back);

        // Damos funcionalidad a la flecha de retorno
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish(); // Volver a la actividad anterior
            }
        });

       // Boton para agregar la pregunta
            btnAddQuestion.setOnClickListener(v -> {
                addQuestion();
            });

    }
    //Obtenemos los datos del fichero xml la  parte visual
    private void addQuestion(){
        int correctAnswer;
        boolean isInserted;

        //Obtenemos los datos de la vista
        String question =  etQuestion.getText().toString();
        String answer1 = etAnswer1.getText().toString();
        String answer2 = etAnswer2.getText().toString();
        String answer3 = etAnswer3.getText().toString();

        // Validamos el indice de la respuesta correcta
        try{
            correctAnswer = Integer.parseInt(etRigthAnswer.getText().toString());
        }catch(NumberFormatException e){
            Toast.makeText(this, "Ingrese un número válido para la opción correcta", Toast.LENGTH_LONG).show();
            return;
        }

        // Insertamos la pregunta en la base de datos
        isInserted = dbTrivia.insertQuestion(question, answer1, answer2, answer3, correctAnswer );
        if(isInserted){
            Toast.makeText(this, "Pregunta agregada correctamente", Toast.LENGTH_LONG).show();
            clearFields();
        }else{
            Toast.makeText(this, "Error al agregar la pregunta", Toast.LENGTH_LONG).show();
        }
    }

    private void clearFields(){
            etQuestion.getText().clear();
            etAnswer1.getText().clear();
            etAnswer2.getText().clear();
            etAnswer3.getText().clear();
            etRigthAnswer.getText().clear();
    }
}
