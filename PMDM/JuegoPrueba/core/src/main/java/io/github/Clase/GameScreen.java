package io.github.Clase;

import com.badlogic.gdx.Screen;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;
import com.badlogic.gdx.utils.ScreenUtils;

public class GameScreen implements Screen {
    private final Main game;
    private SpriteBatch batch;
    private Texture ba;

    public GameScreen(){

    }

    public void show(){
        batch = new SpriteBatch();

    }

    public void render(float data){
        ScreenUtils.clear(.1f, 0.1f, 0.1f, 1);
        batch.begin();
        batch.draw(background);
        batch.end();
    }
}
