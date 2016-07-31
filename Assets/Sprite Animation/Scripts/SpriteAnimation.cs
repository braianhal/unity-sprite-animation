using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class SpriteAnimation {

    public string name;
    public List<Sprite> sprites;

    private int currentSprite = 0;

    
    public void play(SpriteRenderer target, float FPS)
    {

    }

}
