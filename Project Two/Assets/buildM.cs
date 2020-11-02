using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildM: MonoBehaviour
{
    private Transform myTransform;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        speed = Random.Range(100f, 210f);
    }
    // Update is called once per frame
    void Update()
    {
        myTransform.position += Vector3.left * Time.deltaTime * speed;

        if (myTransform.position.x < -30)
        {
            myTransform.position += Vector3.right * 880;
        }
    }
}