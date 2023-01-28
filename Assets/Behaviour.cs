using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour
{
    public float Speed = 23;
    public Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalAxis = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(HorizontalAxis * Speed * Time.deltaTime, 0);
        transform.position = transform.position + movement;

        float VerticalAxis = Input.GetAxis("Vertical");
        Vector3 movement2 = new Vector3(0,VerticalAxis * Speed * Time.deltaTime,0);
        transform.position = transform.position + movement2;
        print(VerticalAxis);
    }
}
