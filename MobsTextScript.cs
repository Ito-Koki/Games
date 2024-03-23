using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MobsTextScript : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null; 
    public GameObject[] ContinueCanvas = new GameObject[7];
    public static int Ctextcount;
    public static int Gtextcount;
    public static bool Ekey =false;
    bool[] ctextfin = new bool[6];
    bool gtextfin = false;
    public GameObject ekeyobj;
    // Start is called before the first frame update
    void Start()
    {
        //Gtextcount = 0;//難易度爆上げするなら解除//負けた時最初から話しかける必要が出てくる
        if (Ekey)
        {
            Destroy(ekeyobj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MobA1()
    {
        talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        flowchart.SendFungusMessage("AMob1");
    }
    public void MobA2()
    {
        talkmanager.talkstart();
        ContinueCanvas[1].SetActive(false);
        flowchart.SendFungusMessage("AMob2");
    }
    public void MobA3()
    {
        talkmanager.talkstart();
        ContinueCanvas[2].SetActive(false);
        flowchart.SendFungusMessage("AMob3");
    }
    public void MobA4()
    {
        talkmanager.talkstart();
        ContinueCanvas[3].SetActive(false);
        flowchart.SendFungusMessage("AMob4");
    }
    public void MobB1()
    {
        talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        flowchart.SendFungusMessage("BMob1");
    }

    public void MobC1()
    {
        talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        flowchart.SendFungusMessage("CMob1");
        if (!ctextfin[0])
        {
            ctextfin[0] = true;
            Ctextcount++;
        }
    }

    public void MobC2()
    {
        talkmanager.talkstart();
        ContinueCanvas[1].SetActive(false);
        flowchart.SendFungusMessage("CMob2");
        if (!ctextfin[1])
        {
            ctextfin[1] = true;
            Ctextcount++;
        }
    }

    public void MobC3()
    {
        talkmanager.talkstart();
        ContinueCanvas[2].SetActive(false);
        flowchart.SendFungusMessage("CMob3");
        if (!ctextfin[2])
        {
            ctextfin[2] = true;
            Ctextcount++;
        }
    }

    public void MobC4()
    {
        talkmanager.talkstart();
        ContinueCanvas[3].SetActive(false);
        flowchart.SendFungusMessage("CMob4");
        if (!ctextfin[3])
        {
            ctextfin[3] = true;
            Ctextcount++;
        }
    }

    public void MobC5()
    {
        talkmanager.talkstart();
        ContinueCanvas[4].SetActive(false);
        flowchart.SendFungusMessage("CMob5");
        if (!ctextfin[4])
        {
            ctextfin[4] = true;
            Ctextcount++;
        }
    }
    public void MobD1()
    {
        talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        flowchart.SendFungusMessage("DMob1");
    }
    public void MobD2()
    {
        talkmanager.talkstart();
        ContinueCanvas[1].SetActive(false);
        flowchart.SendFungusMessage("DMob2");
    }
    public void MobD3()
    {
        talkmanager.talkstart();
        ContinueCanvas[2].SetActive(false);
        flowchart.SendFungusMessage("DMob3");
    }
    public void MobD4()
    {
        talkmanager.talkstart();
        ContinueCanvas[3].SetActive(false);
        flowchart.SendFungusMessage("DMob4");
    }

    public void MobE1()
    {
        talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        flowchart.SendFungusMessage("EMob1");
    }
    public void MobE2()
    {
        talkmanager.talkstart();
        ContinueCanvas[1].SetActive(false);
        flowchart.SendFungusMessage("EMob2");
    }
    public void MobE3()
    {
        talkmanager.talkstart();
        ContinueCanvas[2].SetActive(false);
        flowchart.SendFungusMessage("EMob3");
    }
    public void MobEKey()
    {
        talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        flowchart.SendFungusMessage("EKey");
        Ekey = true;
        GameObject tmpa = GameObject.Find("EkeyObject");
        Destroy(tmpa);
    }

    public void MobF1()
    {
        talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        flowchart.SendFungusMessage("FMob1");
    }
    public void MobF2()
    {
        talkmanager.talkstart();
        ContinueCanvas[1].SetActive(false);
        flowchart.SendFungusMessage("FMob2");
    }
    public void MobF3()
    {
        talkmanager.talkstart();
        ContinueCanvas[2].SetActive(false);
        flowchart.SendFungusMessage("FMob3");
    }

    public void MobG1()
    {
        talkmanager.talkstart();
        ContinueCanvas[0].SetActive(false);
        if (ButtonTScript.gstill == 0 || GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("GMob1sta");
        }
        else
        {
            if (Gtextcount == 0)
            {
                flowchart.SendFungusMessage("GMob1");
                Gtextcount++;
            }
            else if (Gtextcount == 6)
            {
                flowchart.SendFungusMessage("GMobOK");
            }
            else
            {
                flowchart.SendFungusMessage("GMobmiss");
                Gtextcount = 0;
            }
            UnityEngine.Debug.Log(Gtextcount);
        }

    }

    public void MobG2()
    {
        talkmanager.talkstart();
        ContinueCanvas[1].SetActive(false);
        if (ButtonTScript.gstill == 0 || GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("GMob2sta");
        }
        else
        {
            if (Gtextcount == 1)
            {
                flowchart.SendFungusMessage("GMob2");
                Gtextcount++;
            }
            else if (Gtextcount == 6)
            {
                flowchart.SendFungusMessage("GMobOK");
            }
            else
            {
                flowchart.SendFungusMessage("GMobmiss");
                Gtextcount = 0;
            }
            UnityEngine.Debug.Log(Gtextcount);
        }
    }

    public void MobG3()
    {
        talkmanager.talkstart();
        ContinueCanvas[2].SetActive(false);
        if (ButtonTScript.gstill == 0 || GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("GMob3sta");
        }
        else
        {
            if (Gtextcount == 2)
            {
                flowchart.SendFungusMessage("GMob3");
                Gtextcount++;
            }
            else if (Gtextcount == 6)
            {
                flowchart.SendFungusMessage("GMobOK");
            }
            else
            {
                flowchart.SendFungusMessage("GMobmiss");
                Gtextcount = 0;
            }
            UnityEngine.Debug.Log(Gtextcount);
        }
    }

    public void MobG4()
    {
        talkmanager.talkstart();
        ContinueCanvas[3].SetActive(false);
        if (ButtonTScript.gstill == 0 || GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("GMob4sta");
        }
        else
        {
            if (Gtextcount == 3)
            {
                flowchart.SendFungusMessage("GMob4");
                Gtextcount++;
            }
            else if (Gtextcount == 6)
            {
                flowchart.SendFungusMessage("GMobOK");
            }
            else
            {
                flowchart.SendFungusMessage("GMobmiss");
                Gtextcount = 0;
            }
            UnityEngine.Debug.Log(Gtextcount);
        }
    }

    public void MobG5()
    {
        talkmanager.talkstart();
        ContinueCanvas[4].SetActive(false);
        if (ButtonTScript.gstill == 0 || GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("GMob5sta");
        }
        else
        {
            if (Gtextcount == 4)
            {
                flowchart.SendFungusMessage("GMob5");
                Gtextcount++;
            }
            else if (Gtextcount == 6)
            {
                flowchart.SendFungusMessage("GMobOK");
            }
            else
            {
                flowchart.SendFungusMessage("GMobmiss");
                Gtextcount = 0;
            }
            UnityEngine.Debug.Log(Gtextcount);
        }
    }

    public void MobG6()
    {
        talkmanager.talkstart();
        ContinueCanvas[5].SetActive(false);
        if(ButtonTScript.gstill == 0 || GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("GMob6sta");
        }
        else
        {
            if (Gtextcount == 5)
            {
                flowchart.SendFungusMessage("GMob6");
                Gtextcount++;
            }
            else if (Gtextcount == 6)
            {
                flowchart.SendFungusMessage("GMobOK");
            }
            else
            {
                flowchart.SendFungusMessage("GMobmiss");
                Gtextcount = 0;
            }
            UnityEngine.Debug.Log(Gtextcount);
        }
    }
}
