package io.github.some_example_name;

import com.badlogic.gdx.ApplicationAdapter;
import io.github.some_example_name.characters.Enemies;
import com.badlogic.gdx.Game;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.Input;
import com.badlogic.gdx.Screen;
import com.badlogic.gdx.graphics.g2d.Animation;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;
import com.badlogic.gdx.graphics.g2d.TextureAtlas;
import com.badlogic.gdx.graphics.g2d.TextureRegion;
import com.badlogic.gdx.math.Rectangle;
import com.badlogic.gdx.utils.Array;
import com.badlogic.gdx.utils.ScreenUtils;

import io.github.some_example_name.characters.Enemies;

/** {@link com.badlogic.gdx.ApplicationListener} implementation shared by all platforms. */
public class GameScreen implements Screen {
    private SpriteBatch batch;
    private TextureAtlas atlas;
    private float stateTime;
    private Animation <TextureRegion> bigMarioAnimation;
    private float x, y;
    private Boolean isMoving;
    private TextureRegion MarioStop;
    private Boolean isJumping = false;
    private final float GRAVITY = -450;
    private float velocityY = 0;
    private final float JUMP_VELOCITY = 300;
    private final float GROUND_Y = 100;
    private Array<TextureRegion> allFramesJump = new Array<>();
    private TextureRegion currentFrame;


    private Array<Enemies> Enemies;
    private HUD hud;
    private float EnemySpawnerTime;
    private float TimegameOver = 5;

    @Override
    public void show() {
        batch = new SpriteBatch();
        atlas = new TextureAtlas(Gdx.files.internal("Mario_and_Enemies.pack"));
        TextureAtlas.AtlasRegion bigMarioRegion = atlas.findRegion("big_mario");
        int count = bigMarioRegion.getRegionWidth() / 16;

        hud = new HUD();
        EnemySpawnerTime = 0;
        Enemies = new Array<>();

        System.out.println(count);
        MarioStop = new TextureRegion(bigMarioRegion, 0, 0, 16, bigMarioRegion.getRegionHeight());
        Array<TextureRegion> allFrames = new Array<>();
        for (int i = 0; i < 3; i++){
            allFrames.add(new TextureRegion(bigMarioRegion, i * 16, 0, 16, bigMarioRegion.getRegionHeight()));
        }
        for (int i = 5; i < 16; i++){
            allFramesJump.add(new TextureRegion(bigMarioRegion, i * 16, 0, 16, bigMarioRegion.getRegionHeight()));
        }
        bigMarioAnimation = new Animation<>(0.4f, allFrames);
        x = 100;
        y = GROUND_Y;
        isJumping = false;
        isMoving = false;
    }

    @Override
    public void render(float delta) {
        isMoving = false;
        ScreenUtils.clear(0.15f, 0.15f, 0.2f, 1f);
        handleInput();
        applyGravity(delta);
        EnemySpawnerTime = delta;

        if(hud.isGameOver()){
            TimegameOver -= delta;
        }

        if(TimegameOver < 0){
            ((Game) Gdx .app.getApplicationListener()).setScreen(new MainGame());
        }
        if(EnemySpawnerTime > 2){
            Enemies.add(new Enemies(Gdx.graphics.getWidth(), GROUND_Y, atlas));
            System.out.println(Enemies);
            EnemySpawnerTime = 0;
        }
        for(int i = 0; i < Enemies.size; i++){
            Enemies enemy = Enemies.get(i);
            enemy.update(delta);
            System.out.println("Enemigo x:"+enemy.getX());
            Rectangle MarioBounds = new Rectangle(x,y,16,16);
            if(enemy.checkCollision(MarioBounds)){
                System.out.println("Collision encontrada");
                if(velocityY < 0 && y > enemy.getY()){
                    Enemies.removeIndex(i);
                    HUD.increaseScore();
                    velocityY = JUMP_VELOCITY / 2;
                } else {
                    System.out.println("Game Over");
                    hud.setGameOver(false);
                }
            }
        }
        batch.begin();
        stateTime += Gdx.graphics.getDeltaTime();
        currentFrame = bigMarioAnimation.getKeyFrame(stateTime, true);

        if(isMoving){
            batch.draw(currentFrame, x, y, currentFrame.getRegionWidth()*3, currentFrame.getRegionHeight()*3);
        }else {
            batch.draw(MarioStop, x, y, MarioStop.getRegionWidth()*3, MarioStop.getRegionHeight()*3);
        }


        for(Enemies enemy:Enemies){
            enemy.render(batch);
        }
        batch.end();
        hud.render(batch);
    }

    private void applyGravity(float delta){
        if(isJumping){
            isMoving = true;
            bigMarioAnimation = new Animation<>(0.4f, allFramesJump);
           // System.out.println("y="+y+", velocityY= " + velocityY);
            velocityY += GRAVITY * delta;// 300 (-450 * 0.0167) = 291.75 --
            y += velocityY * delta; // 100 + 291.75 * 0.0167 = 104.87
            //System.out.println("y="+y+", velocityY= " + velocityY);
            if(y <= GROUND_Y){
                y = GROUND_Y;
                velocityY = 0;
                isJumping = false;
            }
        }
    }
    private void handleInput(){
        // Movemos el personaje con las teclas
        if(Gdx.input.isKeyPressed(Input.Keys.A)){ // Se puede usar right
            x += 200 * Gdx.graphics.getDeltaTime();
            isMoving = true;
        }
        if(Gdx.input.isKeyPressed(Input.Keys.D)){// Se puede usar left
            x -= 200 * Gdx.graphics.getDeltaTime();
            isMoving = true;
        }
        if(Gdx.input.isKeyPressed(Input.Keys.SPACE) && !isJumping){
            velocityY = JUMP_VELOCITY;
            isJumping = true;
            y += 200 * Gdx.graphics.getDeltaTime();
        }
    }



    @Override
    public void resize(int width, int height) {

    }

    @Override
    public void pause() {

    }

    @Override
    public void resume() {

    }

    @Override
    public void hide() {

    }

    @Override
    public void dispose() {
        batch.dispose();
    }
}
