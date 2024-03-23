using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System.Runtime.CompilerServices;

public class ButtonTScript : MonoBehaviour
{
    public GameObject[] ContinueCanvas = new GameObject[7];
    public Fungus.Flowchart flowchart = null;

    public static int cstill,estill,gstill;
    GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        hero = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TestA()
    {
        //talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        if (GrandGameManager.clearpoint == 0)
        {
            flowchart.SendFungusMessage("AMain");
        }
        if(GrandGameManager.clearpoint == 1)
        {
            flowchart.SendFungusMessage("AMainAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestB()
    {
        talkmanager.talkstart();
        ContinueCanvas[1].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        if (GrandGameManager.clearpoint == 1)
        {
            flowchart.SendFungusMessage("BMain");
        }
        if (GrandGameManager.clearpoint == 2)
        {
            flowchart.SendFungusMessage("BMainAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestC()
    {
        talkmanager.talkstart();
        ContinueCanvas[2].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        if (GrandGameManager.clearpoint == 2)
        {
            if (cstill == 0)
            {
                flowchart.SendFungusMessage("CMain");
                cstill++;
            }
            else
            {
                if (MobsTextScript.Ctextcount < 5)
                {
                    flowchart.SendFungusMessage("CMainStill");
                }
                else
                {
                    flowchart.SendFungusMessage("CMainUntil");
                }

            }
        }
        if (GrandGameManager.clearpoint == 3)
        {
            flowchart.SendFungusMessage("CMainAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestD()
    {
        talkmanager.talkstart();
        ContinueCanvas[3].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        if (GrandGameManager.clearpoint == 3)
        {
            flowchart.SendFungusMessage("DMain");
        }
        if (GrandGameManager.clearpoint == 4)
        {
            flowchart.SendFungusMessage("DMainAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestE()
    {
        talkmanager.talkstart();
        ContinueCanvas[4].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        if (GrandGameManager.clearpoint == 4)
        {
            if (estill == 0)
            {
                flowchart.SendFungusMessage("EMain");
                estill++;
            }
            else
            {
                if (!MobsTextScript.Ekey)
                {
                    flowchart.SendFungusMessage("EMainStill");
                }
                else
                {
                    flowchart.SendFungusMessage("EMainUntil");
                }

            }
        }
        if (GrandGameManager.clearpoint == 5)
        {
            flowchart.SendFungusMessage("EMainAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestF()
    {
        talkmanager.talkstart();
        ContinueCanvas[5].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        if (GrandGameManager.clearpoint == 5)
        {
            flowchart.SendFungusMessage("FMain");
        }
        if (GrandGameManager.clearpoint == 6)
        {
            flowchart.SendFungusMessage("FMainAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestG()
    {
        talkmanager.talkstart();
        ContinueCanvas[6].SetActive(false);
        //DemoCollegeStudentController.direction = 0;


        if (GrandGameManager.clearpoint == 6)
        {
            if (gstill == 0)
            {
                flowchart.SendFungusMessage("GMain");
                gstill++;
            }
            else
            {
                if (MobsTextScript.Gtextcount != 6)
                {
                    flowchart.SendFungusMessage("GMainStill");
                    MobsTextScript.Gtextcount = 0;
                }
                else
                {
                    flowchart.SendFungusMessage("GMainUntil");
                }

            }
        }
        if (GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("CMainAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
}
