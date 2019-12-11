﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonPress()
    {
        GetComponent<AudioSource>().Play();
        Invoke("LoadNextScene", 1.0f);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("Level1");
    }
}