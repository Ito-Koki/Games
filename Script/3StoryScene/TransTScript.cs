using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransTScript : MonoBehaviour
{
    public GameObject[] ContinueCanvas = new GameObject[7];
    public Fungus.Flowchart flowchart = null;
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

        ContinueCanvas[0].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        //GrandGameManager.clearpoint++;
        if (GrandGameManager.clearpoint == 0)
        {
            flowchart.SendFungusMessage("ATransBefore");
        }
        if (GrandGameManager.clearpoint == 1)
        {
            flowchart.SendFungusMessage("ATransAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestB()
    {

        ContinueCanvas[1].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        //GrandGameManager.clearpoint++;
        if (GrandGameManager.clearpoint == 1)
        {
            flowchart.SendFungusMessage("BTransBefore");
        }
        if (GrandGameManager.clearpoint == 2)
        {
            flowchart.SendFungusMessage("BTransAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }

    public void TestC()
    {

        ContinueCanvas[2].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        //GrandGameManager.clearpoint++;
        if (GrandGameManager.clearpoint == 2)
        {
            flowchart.SendFungusMessage("CTransBefore");
        }
        if (GrandGameManager.clearpoint == 3)
        {
            flowchart.SendFungusMessage("CTransAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestD()
    {

        ContinueCanvas[3].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        //GrandGameManager.clearpoint++;
        if (GrandGameManager.clearpoint == 3)
        {
            flowchart.SendFungusMessage("DTransBefore");
        }
        if (GrandGameManager.clearpoint == 4)
        {
            flowchart.SendFungusMessage("DTransAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestE()
    {

        ContinueCanvas[4].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        //GrandGameManager.clearpoint++;
        if (GrandGameManager.clearpoint == 4)
        {
            flowchart.SendFungusMessage("ETransBefore");
        }
        if (GrandGameManager.clearpoint == 5)
        {
            flowchart.SendFungusMessage("ETransAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestF()
    {

        ContinueCanvas[5].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        //GrandGameManager.clearpoint++;
        if (GrandGameManager.clearpoint == 5)
        {
            flowchart.SendFungusMessage("FTransBefore");
        }
        if (GrandGameManager.clearpoint == 6)
        {
            flowchart.SendFungusMessage("FTransAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
    public void TestG()
    {

        ContinueCanvas[6].SetActive(false);
        //DemoCollegeStudentController.direction = 0;
        //GrandGameManager.clearpoint++;
        if (GrandGameManager.clearpoint == 6)
        {
            flowchart.SendFungusMessage("GTransBefore");
        }
        if (GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("GTransAfter");
        }
        //hero.GetComponent<DemoCollegeStudentController(Script)>().enabled = false;
    }
}
