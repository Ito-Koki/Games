using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FungusExecute : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    // Start is called before the first frame update
    void Start()
    {
        flowchart.SendFungusMessage("1");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
