using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Hand hand;
    public Field field;
    public Field opfield;
    public Yama yama;
    public Ayama ayama;
    public Sute sute;
    public int cardnumber;
    public int count1;
    int opsc = 0;
    int oplc = 6;
    public GameObject pushbutton;
    public GameObject transbutton;
    public GameObject pcover;
    void Start()
    {

    }

    public void ButtonPush0()
    {
        Card card;
        card = hand.Pull(cardnumber);
        field.Add(card);
    }
    public void transPush(int position)
    {
        Card card1 = hand.Pull(position);
        int tmp = hand.Pullindex(position);
        sute.Add(card1);
        Card card2;
        if (position < 4)
        {
            card2 = yama.Pull(0);
        }
        else
        {
            card2 = ayama.Pull(0);
        }
        hand.transAdd(card2,tmp,position);
        transbutton.SetActive(false);
        pcover.SetActive(true);
        pushbutton.SetActive(true);
    }

    public void OPPush()
    {
        count1 = BattleManager.count - 1 ;
        Card card;
        if ((count1%2)==0)
        {
            card = hand.Pull(opsc);
            opsc++;
        }
        else
        {
            card = hand.Pull(oplc);
            oplc--;
        }
        opfield.Add(card);

    }
}
