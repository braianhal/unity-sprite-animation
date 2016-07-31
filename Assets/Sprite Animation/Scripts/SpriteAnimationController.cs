using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteAnimationController : MonoBehaviour {

    public List<SpriteAnimation> animations;

    private SpriteRenderer render;

    void Start()
    {
        render = this.GetComponent<SpriteRenderer>();
    }

}
