using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class talkmanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void talkstart()
    {
        GrandGameManager.talk = false;
    }
    public void talkend()
    {
        GrandGameManager.talk = true;
    }
    public void Scene()
    {
        Invoke("Scene1", 1.0f);
    }
    public void Scene1()
    {
        SceneManager.LoadScene("4BattleScene");
    }
}
