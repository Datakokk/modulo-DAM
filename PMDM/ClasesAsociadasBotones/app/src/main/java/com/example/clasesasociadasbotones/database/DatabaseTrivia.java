package com.example.clasesasociadasbotones.database;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.content.ContentValues;

public class DatabaseTrivia extends SQLiteOpenHelper {

    public DatabaseTrivia(Context context) {
        super(context, "trivia.db", null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        // Crear la tabla de preguntas
        String CREATE_TABLE = "CREATE TABLE questions ("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                + "question_text TEXT, "
                + "option1 TEXT, "
                + "option2 TEXT, "
                + "option3 TEXT, "
                + "correct_option INTEGER)";
        db.execSQL(CREATE_TABLE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS questions");
        onCreate(db);
    }

    // Método para insertar una pregunta
    public boolean insertQuestion(String questionText, String option1, String option2, String option3, int correctOption) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put("question_text", questionText);
        contentValues.put("option1", option1);
        contentValues.put("option2", option2);
        contentValues.put("option3", option3);
        contentValues.put("correct_option", correctOption);
        long result = db.insert("questions", null, contentValues);
        db.close();
        return result != -1;
    }

    // Método para leer todas las preguntas
    public Cursor getAllQuestions() {
        SQLiteDatabase db = this.getReadableDatabase();
        return db.rawQuery("SELECT * FROM questions", null);
    }

    // Método para obtener una pregunta específica por ID
    public Cursor getQuestionById(int id) {
        SQLiteDatabase db = this.getReadableDatabase();
        return db.rawQuery("SELECT * FROM questions WHERE id = ?", new String[]{String.valueOf(id)});
    }

    // Método para actualizar una pregunta
    public boolean updateQuestion(int id, String newQuestionText, String newOption1, String newOption2, String newOption3, int newCorrectOption) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put("question_text", newQuestionText);
        contentValues.put("option1", newOption1);
        contentValues.put("option2", newOption2);
        contentValues.put("option3", newOption3);
        contentValues.put("correct_option", newCorrectOption);
        int rowsAffected = db.update("questions", contentValues, "id = ?", new String[]{String.valueOf(id)});
        db.close();
        return rowsAffected > 0;
    }

    // Método para eliminar una pregunta
    public boolean deleteQuestion(int id) {
        SQLiteDatabase db = this.getWritableDatabase();
        int rowsDeleted = db.delete("questions", "id = ?", new String[]{String.valueOf(id)});
        db.close();
        return rowsDeleted > 0;
    }
}
