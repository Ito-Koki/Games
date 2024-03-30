using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class License : MonoBehaviour
{
    public GameObject tmph;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void helping()
    {
        tmph.SetActive(true);
    }
    public void closehelping()
    {
        tmph.SetActive(false);
    }
}
