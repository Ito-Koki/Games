using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;
using System.Net.Mime;

public class BattleManager: MonoBehaviour
{
    public Text textUI;
    GameObject tmptext;
    GameObject tmptext1;
    public static int count;
    public GameObject transbutton;
    public static string[] ptags = { "-1", "-1", "-1", "-1", "-1", "-1", "-1"};
    public static string[] optags = { "-1", "-1", "-1", "-1", "-1", "-1", "-1" };
    public static int playerlastScore, opponentlastScore;
    public Fungus.Flowchart flowchart = null;
    //static int nhand[4];
    //static int ahand[3];
    // Start is called before the first frame update

    void Awake()
    {
        /*tmptext = GameObject.Find("turn");
        count = 0;
        playerlastScore = 0;
        opponentlastScore = 0;
        tmptext.GetComponent<UnityEngine.UI.Text>().text = "0/7";
        tmptext1 = GameObject.Find("goal");
        goal = UnityEngine.Random.Range(-30, 50);
        tmptext1.GetComponent<UnityEngine.UI.Text>().text = goal.ToString();
        */
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void delete()
    {
        Destroy(this.gameObject);
    }
    public void turncount()
    {
        count++;
        textUI.text = count.ToString()+"/7";
        if(count%3 == 0) transbutton.SetActive(true);
    }
    
    public void coverp()
    {
        if (this.GetComponent<Image>().enabled)
        {
            this.GetComponent<Image>().enabled = false;
        }
        else
        {
            this.GetComponent<Image>().enabled = true;
        }
    }
    public void score()
    {
        int pt0 = int.Parse(ptags[0]);
        int pt2 = int.Parse(ptags[2]);
        int pt4 = int.Parse(ptags[4]);
        int pt6 = int.Parse(ptags[6]);
        if (count == 3)
        {
            if (ptags[1] == "A")
            {
                playerlastScore = pt0 + pt2;
            }
            else if (ptags[1] == "B")
            {
                playerlastScore = pt0 - pt2;
            }
            else if (ptags[1] == "C")
            {
                playerlastScore = pt0 * pt2;
            }
        }


        if (count == 5)
        {
            if (ptags[1] == "A")
            {
                if (ptags[3] == "A")
                {
                    playerlastScore += pt4;
                }
                else if (ptags[3] == "B")
                {
                    playerlastScore -= pt4;
                }
                else if (ptags[3] == "C")
                {
                    playerlastScore = pt0 + pt2 * pt4;
                }
            }
            else if (ptags[1] == "B")
            {
                if (ptags[3] == "A")
                {
                    playerlastScore = calcA(calcB(pt0, pt2), pt4);
                }
                else if (ptags[3] == "B")
                {
                    playerlastScore = calcB(calcB(pt0, pt2), pt4);
                }
                else if (ptags[3] == "C")
                {
                    playerlastScore = calcB(pt0, calcC(pt2, pt4));
                }
            }
            else if (ptags[1] == "C")
            {
                if (ptags[3] == "A")
                {
                    playerlastScore = calcA(calcC(pt0, pt2), pt4);
                }
                else if (ptags[3] == "B")
                {
                    playerlastScore = calcB(calcC(pt0, pt2), pt4);
                }
                else if (ptags[3] == "C")
                {
                    playerlastScore = calcC(pt0, calcC(pt2, pt4));
                }
            }
        }
        if (count == 7)
        {
            if (ptags[1] == "A")
            {
                if (ptags[3] == "A")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcA(calcA(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcA(calcA(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcA(pt0, calcA(pt2, calcC(pt4, pt6)));
                    }
                }
                else if (ptags[3] == "B")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcB(calcA(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcB(calcA(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcB(calcA(pt0, pt2), calcC(pt4, pt6));
                    }
                }
                else if (ptags[3] == "C")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcA(pt0, calcC(pt2, pt4)), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcA(pt0, calcC(pt2, pt4)), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcA(pt0, calcC(pt2, calcC(pt4, pt6)));
                    }
                }
            }
            else if (ptags[1] == "B")
            {
                if (ptags[3] == "A")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcA(calcB(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcA(calcB(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcA(calcB(pt0, pt2), calcC(pt4, pt6));
                    }
                }
                else if (ptags[3] == "B")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcB(calcB(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcB(calcB(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcB(calcB(pt0, pt2), calcC(pt4, pt6));
                    }
                }
                else if (ptags[3] == "C")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcB(pt0, calcC(pt2, pt4)), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcB(pt0, calcC(pt2, pt4)), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcB(pt0, calcC(pt2, calcC(pt4, pt6)));
                    }
                }
            }
            else if (ptags[1] == "C")
            {
                if (ptags[3] == "A")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcA(calcC(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcA(calcC(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcA(calcC(pt0, pt2), calcC(pt4, pt6));
                    }
                }
                else if (ptags[3] == "B")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcB(calcC(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcB(calcC(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcB(calcC(pt0, pt2), calcC(pt4, pt6));
                    }
                }
                if (ptags[3] == "C")
                {
                    if (ptags[5] == "A")
                    {
                        playerlastScore = calcA(calcC(calcC(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "B")
                    {
                        playerlastScore = calcB(calcC(calcC(pt0, pt2), pt4), pt6);
                    }
                    else if (ptags[5] == "C")
                    {
                        playerlastScore = calcC(calcC(pt0, pt2), calcC(pt4, pt6));
                    }
                }
            }
        }
        textUI.text = playerlastScore.ToString();
    }

    public void opscore()
    {
        int opt0 = int.Parse(optags[0]);
        int opt2 = int.Parse(optags[2]);
        int opt4 = int.Parse(optags[4]);
        int opt6 = int.Parse(optags[6]);
        if (count == 3)
        {
            if (optags[1] == "A")
            {
                opponentlastScore = calcA(opt0, opt2);
            }
            else if (optags[1] == "B")
            {
                opponentlastScore = calcB(opt0, opt2);
            }
            else if (optags[1] == "C")
            {
                opponentlastScore = calcC(opt0, opt2);
            }
        }



        if (count == 5)
        {
            if (optags[1] == "A")
            {
                if (optags[3] == "A")
                {
                    opponentlastScore = calcA(calcA(opt0, opt2), opt4);
                }
                else if (optags[3] == "B")
                {
                    opponentlastScore = calcB(calcA(opt0, opt2), opt4);
                }
                else if (optags[3] == "C")
                {
                    opponentlastScore = calcA(opt0, calcC(opt2, opt4));
                }
            }
            else if (optags[1] == "B")
            {
                if (optags[3] == "A")
                {
                    opponentlastScore = calcA(calcB(opt0, opt2), opt4);
                }
                else if (optags[3] == "B")
                {
                    opponentlastScore = calcB(calcB(opt0, opt2), opt4);
                }
                else if (optags[3] == "C")
                {
                    opponentlastScore = calcB(opt0, calcC(opt2, opt4));
                }
            }
            else if (optags[1] == "C")
            {
                if (optags[3] == "A")
                {
                    opponentlastScore = calcA(calcC(opt0, opt2), opt4);
                }
                else if (optags[3] == "B")
                {
                    opponentlastScore = calcB(calcC(opt0, opt2), opt4);
                }
                else if (optags[3] == "C")
                {
                    opponentlastScore = calcC(opt0, calcC(opt2, opt4));
                }
            }
        }
        if (count == 7)
        {
            if (optags[1] == "A")
            {
                if (optags[3] == "A")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcA(calcA(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcA(calcA(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcA(opt0, calcA(opt2, calcC(opt4, opt6)));
                    }
                }
                else if (optags[3] == "B")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcB(calcA(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcB(calcA(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcB(calcA(opt0, opt2), calcC(opt4, opt6));
                    }
                }
                else if (optags[3] == "C")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcA(opt0, calcC(opt2, opt4)), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcA(opt0, calcC(opt2, opt4)), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcA(opt0, calcC(opt2, calcC(opt4, opt6)));
                    }
                }
            }
            else if (optags[1] == "B")
            {
                if (optags[3] == "A")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcA(calcB(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcA(calcB(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcA(calcB(opt0, opt2), calcC(opt4, opt6));
                    }
                }
                else if (optags[3] == "B")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcB(calcB(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcB(calcB(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcB(calcB(opt0, opt2), calcC(opt4, opt6));
                    }
                }
                else if (optags[3] == "C")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcB(opt0, calcC(opt2, opt4)), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcB(opt0, calcC(opt2, opt4)), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcB(opt0, calcC(opt2, calcC(opt4, opt6)));
                    }
                }
            }
            else if (optags[1] == "C")
            {
                if (optags[3] == "A")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcA(calcC(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcA(calcC(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcA(calcC(opt0, opt2), calcC(opt4, opt6));
                    }
                }
                else if (optags[3] == "B")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcB(calcC(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcB(calcC(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcB(calcC(opt0, opt2), calcC(opt4, opt6));
                    }
                }
                if (optags[3] == "C")
                {
                    if (optags[5] == "A")
                    {
                        opponentlastScore = calcA(calcC(calcC(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "B")
                    {
                        opponentlastScore = calcB(calcC(calcC(opt0, opt2), opt4), opt6);
                    }
                    else if (optags[5] == "C")
                    {
                        opponentlastScore = calcC(calcC(opt0, opt2), calcC(opt4, opt6));
                    }
                }
            }
            this.Invoke("Judge", 3.0f);
        }

        UnityEngine.Debug.Log("playerlastS="+playerlastScore);
        UnityEngine.Debug.Log("oplayerlastS=" + opponentlastScore);
        textUI.text = opponentlastScore.ToString();
    }

    public void Judge()
    {
        int bgoal = BattleStartManager.goal;
        int perror = bgoal - playerlastScore;
        int operror = bgoal - opponentlastScore;
        UnityEngine.Debug.Log("goal=" + bgoal);
        UnityEngine.Debug.Log("pe="+perror);
        UnityEngine.Debug.Log("ope=" + operror);
        UnityEngine.Debug.Log("ps=" + playerlastScore);
        UnityEngine.Debug.Log("ops=" + opponentlastScore);
        tmptext = GameObject.Find("turn");
        if (perror*perror < operror*operror)
        {
            tmptext.GetComponent<UnityEngine.UI.Text>().text = "win";
            GrandGameManager.battlejudge = true;
            GrandGameManager.clearpoint++;
        }
        else if(perror * perror > operror * operror)
        {
            tmptext.GetComponent<UnityEngine.UI.Text>().text = "lose";
            GrandGameManager.battlejudge = false;
        }
        else
        {
            tmptext.GetComponent<UnityEngine.UI.Text>().text = "draw";
            GrandGameManager.battlejudge = false;
        }
        GrandGameManager.storyafter = true;
        Invoke("SScene", 5.0f);
    }
    public void SScene()
    {
        flowchart.SendFungusMessage("end1");
    }



    int calcA(int a, int b)
    {
        return a + b;
    }
    int calcB(int a, int b)
    {
        return a - b;
    }
    int calcC(int a, int b)
    {
        return a * b;
    }
}
