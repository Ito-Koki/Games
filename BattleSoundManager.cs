using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GrandGameManager.clearpoint = 7;
        if(GrandGameManager.clearpoint < 3)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if(GrandGameManager.clearpoint < 6)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
