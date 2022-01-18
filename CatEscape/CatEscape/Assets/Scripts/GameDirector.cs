using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject player;
    GameObject score;
    private float point;
    GameObject timer;
    public float time;
    private float decreaseTime = 1.0f;
    private float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.player = GameObject.Find("player");
        this.score = GameObject.Find("score");
        this.timer = GameObject.Find("timer");
    }

    void Update()
    {
        delta += Time.deltaTime;
        if (this.delta > this.decreaseTime)
        {
            this.delta = 0;
            time -= decreaseTime;
        }
        this.score.GetComponent<Text>().text = "현재 점수:" + point + "점";
        this.timer.GetComponent<Text>().text = "남은시간:" + time + "초";

    }

    public void DecreaseHp()
    {
        this.player.GetComponent<PlayerController>().Hp -= 1;
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
