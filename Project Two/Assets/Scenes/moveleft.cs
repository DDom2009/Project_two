using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class moveleft : MonoBehaviour
{

    public Transform myTransform;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        speed = 200;
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += Vector3.left * Time.deltaTime * speed;

        if (myTransform.position.x < 8)
        {
            myTransform.position += Vector3.right * 16;
        }
    }
}