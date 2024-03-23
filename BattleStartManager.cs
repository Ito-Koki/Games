using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleStartManager : MonoBehaviour
{
    public Text textUI;
    GameObject tmptext;
    GameObject tmptext1;
    public GameObject transbutton;
    public static int goal;

    void Start()
    {
        UnityEngine.Debug.Log("Start");
        tmptext = GameObject.Find("turn");
        BattleManager.count = 0;
        BattleManager.playerlastScore = 0;
        BattleManager.opponentlastScore = 0;
        tmptext.GetComponent<UnityEngine.UI.Text>().text = "0/7";
        tmptext1 = GameObject.Find("goal");
        if (GrandGameManager.clearpoint < 3)
        {
            goal = UnityEngine.Random.Range(0, 50);
        }
        else
        {
            goal = UnityEngine.Random.Range(-30, 80);
        }
        tmptext1.GetComponent<UnityEngine.UI.Text>().text = goal.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
