using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMainCharacterScript : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    // Start is called before the first frame update
    void Start()
    {
        if (GrandGameManager.storyafter)
        {
            if (GrandGameManager.battlejudge)
            {
                flowchart.SendFungusMessage(GrandGameManager.clearpoint+"Clear");
            }
            else
            {
                flowchart.SendFungusMessage(GrandGameManager.clearpoint+"Miss");
                GrandGameManager.storyafter = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
