using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public bool isPLayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPLayer1)
        {
            movement3 = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement3 = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement3 * speed);

    }
}
