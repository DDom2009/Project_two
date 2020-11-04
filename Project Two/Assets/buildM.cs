using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class buildM: MonoBehaviour
{
    private Transform myTransform;
    public float speed;
    public float Xrange;
    
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        speed = Random.Range(50f, 200f);
        Xrange = Random.Range(880f, 1000f);
    }
    // Update is called once per frame
    void Update()
    {
        myTransform.position += Vector3.left * Time.deltaTime * speed;

        if (myTransform.position.x < -60)
        {
            myTransform.position += Vector3.right * Xrange;
        }
    }
}