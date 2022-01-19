using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Hp;
    public float maxHp;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            this.MoveRight();
        }
    }

    private void MoveLeft() {
        if (this.transform.position.x > -8)
        {
            this.transform.Translate(-3, 0, 0);
        }

        if (this.transform.position.x <= -8)
        {
            this.transform.position = new Vector3(-8, -3.59f, 0);
        }
    }

    private void MoveRight() {
        if (this.transform.position.x < 8)
        {
            this.transform.Translate(3, 0, 0);
        }

        if (this.transform.position.x >= 8)
        {
            this.transform.position = new Vector3(8, -3.59f, 0);
        }
    }

    public void LButtonDown()
    {
        this.MoveLeft();
    }

    public void RButtonDown()
    {
        this.MoveRight();
    }
}
