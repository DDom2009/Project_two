using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collsion)
    {

        if (collsion .gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
