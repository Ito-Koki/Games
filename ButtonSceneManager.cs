using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
public class ButtonSceneManager : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Test()
    {
        flowchart.SendFungusMessage("start");
        this.GetComponent<AudioSource>().enabled = true;
        Invoke("SM", 1.0f);
    }
    public void SM()
    {
        SceneManager.LoadScene("2LoadScene");
    }
}
