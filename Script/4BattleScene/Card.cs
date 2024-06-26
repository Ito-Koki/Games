using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    private Image img;
    private Sprite ura;
    private Sprite omote;
    void Start()
    {
        img = GetComponent<Image>();
        // 裏面の画像(Assets/Resource/Sprites/ura.png)
        ura = Resources.Load<Sprite>("Material/cardback");

        // 表面の画像
        //omote = Resources.Load<Sprite>("Material/testcarddesign");

        // 最初は裏面を表示する
        //this.gameObject.GetComponent<Image>().sprite = omote;
    }

    void Update()
    {

    }

    public void cardOpen()
    {
        float speed = 500f;
        float angle = -180f;
        transform.SetAsFirstSibling();
        this.gameObject.GetComponent<Image>().sprite = omote;
        //回転させる
        while (angle < 0f)
        {
            angle += speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, angle, 0);
            Task.Delay(TimeSpan.FromSeconds(0.01f));
        }

        transform.eulerAngles = new Vector3(0, 0, 0);
    }

}
