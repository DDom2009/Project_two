﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    private Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void OnTrigger(Collider other)
    {
        if (other.gameObject.tag == "cube")
        {
            Application.LoadLevel(scene.name);
        }
        else
        {

        }
    }
}
