using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadControllScript : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    // Start is called before the first frame update
    void Start()
    {
        //GrandGameManager.clearpoint = 6;
        if (GrandGameManager.clearpoint == 0)
        {
            flowchart.SendFungusMessage("start-A");
        }
        if (GrandGameManager.clearpoint == 1)
        {
            flowchart.SendFungusMessage("A-B");
        }
        if (GrandGameManager.clearpoint == 2)
        {
            flowchart.SendFungusMessage("B-C");
        }
        if (GrandGameManager.clearpoint == 3)
        {
            flowchart.SendFungusMessage("C-D");
        }
        if (GrandGameManager.clearpoint == 4)
        {
            flowchart.SendFungusMessage("D-E");
        }
        if (GrandGameManager.clearpoint == 5)
        {
            flowchart.SendFungusMessage("E-F");
        }
        if (GrandGameManager.clearpoint == 6)
        {
            flowchart.SendFungusMessage("F-G");
        }
        if (GrandGameManager.clearpoint == 7)
        {
            flowchart.SendFungusMessage("G-last");
        }

        if(GrandGameManager.clearpoint > 0)
        {
            GrandGameManager.storyafter = false;
            GrandGameManager.battlejudge = false;
        }

    }
        // Update is called once per frame
    void Update()
    {
        
    }
}
