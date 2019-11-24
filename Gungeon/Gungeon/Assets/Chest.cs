﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    //public Animator chest;
    public GameObject[] objects;
    public Transform spawnPoint;
    private GameObject item;
    private bool chestOpened;
    public float Timer = 5;

    private void Update()
    {
        Timer -= Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player") && Timer <= 0)  //&& ((Timer - Time.deltaTime) <= 0) //&& !chestOpened)
        {
            //chestOpened = true;
            GetComponent<Animator>().SetBool("open",true);
            item = Instantiate(objects[Random.Range(0, objects.Length)], spawnPoint.position, spawnPoint.rotation) as GameObject;
            Timer = 5;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(item);
            GetComponent<Animator>().SetBool("open", false);
        }
    }
}
