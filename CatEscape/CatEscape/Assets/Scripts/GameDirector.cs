using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject player;
    GameObject score;
    public float point;
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
        UI_Method();
    }

    private void UI_Method()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.decreaseTime && this.player.GetComponent<PlayerController>().Hp > 0)
        {
            this.delta = 0;
            time -= decreaseTime;
        }

        if (this.player.GetComponent<PlayerController>().Hp > 0 && this.time > 0)
        {
            this.score.GetComponent<Text>().text = "���� ����:" + point + "��";
            this.timer.GetComponent<Text>().text = "�����ð�:" + time + "��";
        }
        else if(this.player.GetComponent<PlayerController>().Hp == 0 || this.time == 0)
        {
            this.score.GetComponent<Text>().text = "���� ����:" + point + "��";
            this.timer.GetComponent<Text>().text = "�����ð�:" + time + "��" + "\n" + "���ӿ���";
        }
    }

    public void DecreaseHp()
    {
        this.player.GetComponent<PlayerController>().Hp -= 1f;
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void GetPoint()
    {
        this.point += 1f;
    }
}
