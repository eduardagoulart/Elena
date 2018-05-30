using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{

    public float speed = 0;
    private Material mat;
    private GameObject p1;
    private Vector2 move = Vector2.zero;

    float pos = 0;

    void Start()
    {

        mat = GetComponent<Renderer>().material;
        p1 = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var vel = p1.GetComponent<Rigidbody2D>().velocity.x;
        move.x = Input.GetAxis("Horizontal");

        if (vel != 0f)
        {
            var side = move.x;
            pos += speed * side;
            mat.mainTextureOffset = new Vector2(pos, 0);
        }
    }
}