using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    private GameObject player;
    private GameObject director;
    private float span = 1.0f;
    private float delta = 0;

    void Start()
    {
        this.player = GameObject.Find("player");
        this.director = GameObject.Find("GameDirector");
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span && player.GetComponent<PlayerController>().Hp > 0 && director.GetComponent<GameDirector>().time > 0)
        {
            this.delta = 0;
            GameObject go = Instantiate<GameObject>(arrowPrefab);

            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
