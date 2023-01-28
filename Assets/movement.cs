using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float Speed;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float VerticalAxis = Input.GetAxis("Vertical");
        Vector3 movement2 = new Vector3(0, VerticalAxis * Speed * Time.deltaTime, 0);
        transform.position = transform.position + movement2;
        print(VerticalAxis);

    }
}
