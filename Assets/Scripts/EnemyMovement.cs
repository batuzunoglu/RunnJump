using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyMovement : MonoBehaviour
{

    public float speed;

    private Transform target;




    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        speed = speed + FindObjectOfType<CollectibleSpawner>().speedChange;

        if (transform.position.y < -1)
        {
            print("I have fallen off ground.");
            SceneManager.LoadScene("EndScene");

        }
    }

}