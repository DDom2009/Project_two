using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
     //Start is called before the first frame update
    float speed = 5f;

    // Update is called once per frame
    // Start is called before the first frame update
    void Update()
    {
         if (Input.GetKey(KeyCode.W))
              transform.position += Vector3.up * speed;
          //if (Input.GetKey(KeyCode.S))
              //transform.position += Vector3.down * speed;
          if (Input.GetKey(KeyCode.A))
              transform.position += Vector3.left * speed;
          if (Input.GetKey(KeyCode.D))
              transform.position += Vector3.right * speed;


    }
}
