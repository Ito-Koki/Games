using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MobsTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && GrandGameManager.talk == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
