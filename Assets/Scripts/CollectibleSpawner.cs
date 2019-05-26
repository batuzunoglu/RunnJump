﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Collectibe;
    public float height;

    public float speedChange;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newCollectible = Instantiate(Collectibe);
            newCollectible.layer = Collectibe.layer;
            newCollectible.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newCollectible, 10);
            timer = 0;
         
        }
        timer += Time.deltaTime;
    }


 
}
