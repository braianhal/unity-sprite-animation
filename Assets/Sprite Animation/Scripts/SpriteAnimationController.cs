using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteAnimationController : MonoBehaviour {

    public float FPS;
    public List<SpriteAnimation> animations;

    private SpriteRenderer render;

    void Start()
    {
        render = this.GetComponent<SpriteRenderer>();
    }

    public void run(string animationName)
    {
        try
        {
            animationWithName(animationName).play(render, transitionTime());
        }
        catch
        {
            throw new NoSuchAnimationException();
        }
    }

    private SpriteAnimation animationWithName(string name)
    {
        return animations.Find(anim => anim.name == name);
    }

    private float transitionTime()
    {
        return 1 / this.FPS;
    }

    void Update()
    {

    }

}
