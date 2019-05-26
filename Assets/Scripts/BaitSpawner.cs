using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaitSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Bait;
    public float height;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newBait = Instantiate(Bait);
            newBait.layer = Bait.layer;
            newBait.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newBait, 10);
            timer = 0;

        }
        timer += Time.deltaTime;
    }
}
