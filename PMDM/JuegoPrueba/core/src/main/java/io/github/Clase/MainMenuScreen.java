package io.github.Clase;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.Screen;
import com.badlogic.gdx.graphics.GL20;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.BitmapFont;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;
import com.badlogic.gdx.math.Vector2;
import com.badlogic.gdx.utils.ScreenUtils;
import com.badlogic.gdx.math.Rectangle;


/** {@link com.badlogic.gdx.ApplicationListener} implementation shared by all platforms. */
public class MainMenuScreen implements Screen {
    private final Main game;
    private SpriteBatch batch;
    private BitmapFont font;
    private Texture playButtonTexture, exitButtonTexture;
    private Rectangule playButtonBounds;

    public MainMenuScreen(Main){
        this.game = game;
    }

    public void show(){
        batch = new SpriteBatch();
        font = new BitmapFont();
        playButtonTexture = new Texture("button_play.png");
        exitButtonTexture = new Texture("button_exit.png");

        float buttonWidth = Math.max(playButtonTexture.getWidth(), exitButtonTexture.getWidth());
        float buttonHeight = Math.max(playButtonTexture.getHeight(), exitButtonTexture.getHeight());

        playButtonBounds = new Rectangle(140, 250, buttonWidth, buttonHeight);
        exitButtonTexture = new Rectangle(140, 150, buttonWidth, buttonHeight);

        backgroundMusic = Gdx.audio.newSound(Gdx.files.internal("sound.mpe"));
        backgroundMusic.loop();

    }

    @Override
    public void render() {
        Gdx.gl.glClearColor(0.15f, 0.15f, 0.2f, 0.2f);
        batch.draw(playButtonTexture, playButtonBounds.x, playButtonBounds.y);
        batch.draw(exitButtonTexture, exitButtonBounds.x, exitButtonBounds.y);
        batch.end;
        handleInput();
    }

    private void handleInput(){
        if(Gdx.input.justTouched()){
            Vector2 touchPos = new Vector2(Gdx.input.getX(), Gdx.graphics.getHeight() - Gdx.input.getY());
            if(playButtonBounds.contains(touchPos)){
                game.setScreen(new GameScreeen());
            } else if (exitButtonBounds.contain(touchPos)) {

                Gdx.app.exit();
            }
        }
    }

    @Override
    public void dispose() {
        batch.dispose();
        font.dispose();
        playButton.dispose();
        exitButtonTexture.dispose();
        playButtonTexture.dispose();
    }

}
