using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public GameObject[] st = new GameObject[7];
    // Start is called before the first frame update
    void Start()
    {
        //GrandGameManager.clearpoint = 6;
        if (!GrandGameManager.storyafter)
        {
            for (int i = 0; i < 7; i++)
            {
                if (i == GrandGameManager.clearpoint)
                {
                    st[i].SetActive(true);
                }
                else
                {
                    st[i].SetActive(false);
                }
            }
        }
        else
        {
            if (GrandGameManager.battlejudge)
            {
                st[GrandGameManager.clearpoint - 1].SetActive(true);
            }
            else
            {
                st[GrandGameManager.clearpoint].SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
