using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;
//using static System.Net.Mime.MediaTypeNames;

public class LampScript : MonoBehaviour
{
    private float cnt,cntt;
    float red, green, blue, alpha;
    float redt, greent, bluet, alphat;
    public float turning = 1.0f, turningt = 1.0f;
    public bool button, text;
    public bool once,oncet;
    int count,countt;

    // Start is called before the first frame update
    void Start()
    {
        cnt = 0.0f;cntt = 0.0f;
        count = 0;countt = 0;
        if (GetComponent<Image>())
        {
            red = GetComponent<Image>().color.r;
            green = GetComponent<Image>().color.g;
            blue = GetComponent<Image>().color.b;
            alpha = GetComponent<Image>().color.a;
        }
        if (GetComponent<Text>())
        {
            redt = GetComponent<Text>().color.r;
            greent = GetComponent<Text>().color.g;
            bluet = GetComponent<Text>().color.b;
            alphat = GetComponent<Text>().color.a;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (button) Buttonlamp();
        if (text) Textlamp();
    }
    void Buttonlamp()
    {
        cnt += 1 / turning;
        if (cnt >= 1.00f)
        {
            cnt = 0.00f;
            count++;
        }
        if (once)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alpha * cnt);
            if (count > 0) GetComponent<Text>().color = new Color(red, green, blue, 1.00f);
        }
        if ((count % 2) == 0)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alpha * cnt);
        }
        else
        {
            GetComponent<Image>().color = new Color(red, green, blue, alpha * (1.00f - cnt));
        }
    }

    void Textlamp()
    {
        cntt += 1 / turningt;
        if (cntt >= 1.00f)
        {
            cntt = 0.00f;
            countt++;
        }
        if (oncet)
        {
            GetComponent<Text>().color = new Color(redt, greent, bluet, alphat * cntt);
            if (countt > 0) GetComponent<Text>().color = new Color(redt, greent, bluet, 1.00f);
        }
        else
        {
            if ((countt % 2) == 0)
            {
                GetComponent<Text>().color = new Color(redt, greent, bluet, alphat * cntt);
            }
            else
            {
                GetComponent<Text>().color = new Color(redt, greent, bluet, alphat * (1.00f - cntt));
            }
        }
    }
}
