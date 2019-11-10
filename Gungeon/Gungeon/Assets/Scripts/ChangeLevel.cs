﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeLevel : MonoBehaviour
{ 

public string level;

void OnTriggerEnter2D(Collider2D col) 
{
    if (col.CompareTag("Player"))
    {
      
        Debug.Log("Entered trigger");
        SceneManager.LoadScene(level);
    }
}
}
