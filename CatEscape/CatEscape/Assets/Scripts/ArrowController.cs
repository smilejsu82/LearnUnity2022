using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private GameObject player;
    private GameObject director;

    void Start()
    {
        this.player = GameObject.Find("player");
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        this.transform.Translate(0, -0.1f, 0);

        if(this.transform.position.y < -4.0f)
        {
            director.GetComponent<GameDirector>().GetPoint();
            Destroy(this.gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;

        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d < r1+r2)
        {
            director.GetComponent<GameDirector>().DecreaseHp();
  
            Destroy(gameObject);
        }
    }
}
