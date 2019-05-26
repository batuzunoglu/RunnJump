using UnityEngine;
public class DistanceChecker : MonoBehaviour
{
    public float musicChangeDistance = 2f;
    private Transform player;
    private Transform enemy;
    private PlayAudio playAudio;
    private bool enemyClose;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        playAudio = Camera.main.GetComponent<PlayAudio>();
    }

    private void Update()
    {

        if (Vector2.Distance(player.position, enemy.transform.position) < musicChangeDistance)
        {
                playAudio.PlayClip(1,false);
        }
        else
        {
                playAudio.PlayClip(0, false);
        }
    }
}