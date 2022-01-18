using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Hp;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void LButtonDown()
    {
        if (this.transform.position.x > -8)
        {
            this.transform.Translate(-3, 0, 0);
        }

        if(this.transform.position.x <= -8)
        {
            this.transform.position = new Vector3(-8, -3.59f, 0);
        }
    }

    public void RButtonDown()
    {
        if (this.transform.position.x < 8)
        {
            this.transform.Translate(3, 0, 0);
        }

        if (this.transform.position.x >= 8)
        {
            this.transform.position = new Vector3(8, -3.59f, 0);
        }
    }
}
