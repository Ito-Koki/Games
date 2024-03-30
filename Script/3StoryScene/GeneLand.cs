using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneLand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!GrandGameManager.battlejudge)
        {
            if(GrandGameManager.clearpoint < 2)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "B.C.????/???";
            }
            else
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "A.D.????/???";
            }
        }
        else
        {
            if(GrandGameManager.clearpoint == 1)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "B.C.550/Greece";
            }
            if (GrandGameManager.clearpoint == 2)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "B.C.212/Rome";
            }
            if (GrandGameManager.clearpoint == 3)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "A.D.640/India";
            }
            if (GrandGameManager.clearpoint == 4)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "A.D.1202/Italy";
            }
            if (GrandGameManager.clearpoint == 5)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "A.D.1640/France";
            }
            if (GrandGameManager.clearpoint == 6)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "A.D.1748/Switzerland";
            }
            if (GrandGameManager.clearpoint == 7)
            {
                this.GetComponent<UnityEngine.UI.Text>().text = "A.D.1996/Britain";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
