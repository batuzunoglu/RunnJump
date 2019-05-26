using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectible : MonoBehaviour
{
    public bool incremental; //False = Slows enemy down, True = increases his speed
    public float increase = 0.1f;
    public float decrease = 0.1f;
    private EnemyMovement enemy;
    private PlayAudio playAudio;

    private void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyMovement>();
        playAudio = Camera.main.GetComponent<PlayAudio>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (incremental)
            {
                playAudio.PlayClip(3, true);
                enemy.speed += increase;
            }
            else
            {
                playAudio.PlayClip(2, true);
                enemy.speed -= decrease;
            }

            Destroy(gameObject);
        }
    }
}