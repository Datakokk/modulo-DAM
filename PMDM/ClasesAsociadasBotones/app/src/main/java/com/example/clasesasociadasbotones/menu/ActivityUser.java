package com.example.clasesasociadasbotones.menu;

import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.clasesasociadasbotones.R;
import com.example.clasesasociadasbotones.database.DatabaseTrivia;

public class ActivityUser extends AppCompatActivity {

    private Button btnAnswer1, btnAnswer2, btnAnswer3, btnReset;
    private TextView tvQuestions, tvScore;
    private DatabaseTrivia dbTribia;
    private Cursor questionsCursor;
    private int correctAnswers = 0;
    private int correctOptionIndex;
    ImageView btnBack;

        protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_user);

        // Cambiar el color de la barra de estado solo para esta actividad+
            Window window = getWindow();
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(ContextCompat.getColor(this, android.R.color.holo_blue_light)); // Uso del color predefinido

        // Inicializamos los elementos de la interfaz
            tvQuestions = findViewById(R.id.tv_show_questions);
            tvScore = findViewById(R.id.tv_score);
            btnAnswer1 = findViewById(R.id.btn_answer1);
            btnAnswer2 = findViewById(R.id.btn_answer2);
            btnAnswer3 = findViewById(R.id.btn_answer3);
            btnBack = findViewById(R.id.btn_back);
            btnReset = findViewById(R.id.btn_reset);

            dbTribia = new DatabaseTrivia(this);

        // Damos funcionalidad a la flecha de retorno
            btnBack.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    finish(); // Volver a la actividad anterior
                }
            });

       // Botones de opciones de respuesta con tres formas de enfoque
            btnAnswer1.setOnClickListener(this::checkAnswer);
            btnAnswer2.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    checkAnswer(v);
                }
            });
            btnAnswer3.setOnClickListener(v -> {
                checkAnswer(v);
            });


        // Reiniciar el juego
          btnReset.setOnClickListener(v -> {
              resetGame();
          });

        // Cargar la primera pregunta
        loadQuestion();
        displayNextQuestion();

    }

    // Cargar todas las preguntas
    private void loadQuestion(){
        questionsCursor = dbTribia.getAllQuestions();
        if(!questionsCursor.moveToFirst())
            tvQuestions.setText("No hay preguntas disponible");
    }

    // Mostrar la siguiente pregunta
    private void displayNextQuestion(){
        if(questionsCursor != null && !questionsCursor.isAfterLast()){
            int questionTextIndex = questionsCursor.getColumnIndex("question_text");
            int answer1Index = questionsCursor.getColumnIndex("option1");
            int answer2Index = questionsCursor.getColumnIndex("option2");
            int answer3Index = questionsCursor.getColumnIndex("option3");
            int correctOptionIndexCol = questionsCursor.getColumnIndex("correct_option");

            String questionText = questionTextIndex != -1 ? questionsCursor.getString(questionTextIndex) : "Pregunta no encontrada";
            String answer1 =  answer1Index != -1 ? questionsCursor.getString(answer1Index) : "Respuesta 1 no encontrada";
            String answer2 =  answer2Index != -1 ? questionsCursor.getString(answer2Index) : "Respuesta 2 no encontrada";
            String answer3 =  answer3Index != -1 ? questionsCursor.getString(answer3Index) : "Respuesta 3 no encontrada";
            correctOptionIndex =  correctOptionIndexCol != -1 ? questionsCursor.getInt(correctOptionIndexCol) : -1;

            tvQuestions.setText(questionText);
            btnAnswer1.setText(answer1);
            btnAnswer2.setText(answer2);
            btnAnswer3.setText(answer3);

            questionsCursor.moveToNext();
        }else {
            tvQuestions.setText("Juego finalizado");
            disabledOptions();
        }
    }

    // Metodo que verifica si la respuesta es correcta
    private void checkAnswer(View view){
            int selectedOptionIndex;
            if(view == btnAnswer1){
                selectedOptionIndex = 0;
            } else if (view == btnAnswer2) {
                selectedOptionIndex = 1;
            } else {
                selectedOptionIndex = 2;
            }

            if(selectedOptionIndex == correctOptionIndex){
                correctAnswers++;
                tvScore.setText("Puntuacion: " + correctAnswers);
            }
            displayNextQuestion();
    }

    // Desactivar las opciones cuando se termina el juego
    private void  disabledOptions(){
            btnAnswer1.setEnabled(false);
            btnAnswer2.setEnabled(false);
            btnAnswer3.setEnabled(false);
    }

    // Reiniciar el juego
    private void resetGame(){
            correctAnswers = 0;
            tvScore.setText("Puntuación: " + correctAnswers);

            if(questionsCursor != null){
                questionsCursor.close();
            }
            loadQuestion();
            displayNextQuestion();

            // Habilitamos los botones de nuevo
        btnAnswer1.setEnabled(true);
        btnAnswer2.setEnabled(true);
        btnAnswer3.setEnabled(true);
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        if(questionsCursor != null){
            questionsCursor.close();
        }
        dbTribia.close();
    }
}
