package io.github.some_example_name.characters;

import com.badlogic.gdx.graphics.g2d.SpriteBatch;
import com.badlogic.gdx.graphics.g2d.TextureAtlas;
import com.badlogic.gdx.graphics.g2d.TextureRegion;
import com.badlogic.gdx.math.Rectangle;

public class Enemies {
    private float x, y;
    private TextureRegion enemyTexture;
    private float speed = 100;
    private Rectangle enemyArea;

    public Enemies(float startx, float starty, TextureAtlas atlas){
        this.x = startx;
        this.y = starty;
        TextureAtlas.AtlasRegion enemyAtlas = atlas.findRegion("goomba");
        this.enemyTexture = new TextureRegion(enemyAtlas.getTexture(), 227, 11, 16, 16);
        this.enemyArea = new Rectangle(x,y,16,16);
    }

    public void update(float delta){
        x -= speed * delta;
        enemyArea.setPosition(x, y);
    }

    public void render(SpriteBatch batch){
        batch.begin();
        batch.draw(enemyTexture, x, y, enemyTexture.getRegionWidth() * 3, enemyTexture.getRegionHeight() * 4);
        batch.end();
    }

    public Boolean checkCollision(Rectangle player){
       return enemyArea.overlaps(player);
    }

    public float getX(){
        return x;
    }

    public float getY(){
        return y;
    }

    public void setX(float xpos){
        x = xpos;
    }

    public void setY(float ypos){
        y = ypos;
    }
}
