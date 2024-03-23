using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trans : MonoBehaviour
{
    public GameObject pushbutton;
    public GameObject transbutton;
    public GameObject pcover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void transfer()
    {
        pushbutton.SetActive(false);
        transbutton.SetActive(true);
        pcover.SetActive(false);
        this.gameObject.SetActive(false);
    }

}
