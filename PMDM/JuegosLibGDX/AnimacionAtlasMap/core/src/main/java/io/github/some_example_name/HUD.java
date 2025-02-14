package io.github.some_example_name;

import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.graphics.g2d.BitmapFont;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;

public class HUD {
    private static int score;
    private Boolean gameOver;
    private BitmapFont font;

    public HUD(){
        score = 0;
        gameOver = false;
        font = new BitmapFont();
    }

    public static void increaseScore(){
        score++;
    }

    public void setGameOver(Boolean GO){
        gameOver = GO;
    }

    public int getScore(){
        return score;
    }

    public static void setScore(int sc){
        score = sc;
    }

    public Boolean isGameOver(){
        return gameOver;
    }

    public  void render(SpriteBatch batch){
        batch.begin();
        font.draw(batch, "Score: " + score, 20, 400);
        if(gameOver){
            font.draw(batch, "Game Over", Gdx.graphics.getWidth()/2f, Gdx.graphics.getHeight()/2f);
        }
        batch.end();
    }
}
