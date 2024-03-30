using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames.Text;

public class TextlampScript : MonoBehaviour
{

    public Text Qtext;
    public bool once;
    private float cnt;
    float red, green, blue, alpha;
    int check = 0;
    int count;
    // Use this for initialization
    void Start()
    {
        red = Qtext.color.r;
        green = Qtext.color.g;
        blue = Qtext.color.b;
        alpha = Qtext.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        cnt += 0.001f;
        check++;
        if (check == 1000)
        {
            cnt = 0.00f;
            check = 0;
            count++;
        }
        if (once)
        {
            Qtext.color = new Color(red, green, blue, alpha * cnt);
            if(count >0) Qtext.color = new Color(red, green, blue, 1.00f);
        }
        else
        {
            if ((count % 2) == 0)
            {
                Qtext.color = new Color(red, green, blue, alpha * cnt);
            }
            else
            {
                Qtext.color = new Color(red, green, blue, alpha * (1.00f - cnt));
            }
        }
 
    }
}
