using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hand : MonoBehaviour
{
    //public GameObject cardPrefab;
    public Yama yama;
    public Ayama ayama;
    // Start is called before the first frame update
    Card[] ncards = new Card[7];
    void Start()
    {
        Card card;
        for(int i = 0; i < 7; i++)
        {
            if (i < 4)
            {
                card = yama.Pull(0);
            }
            else
            {
                card = ayama.Pull(0);
            }
            ncards[i] = card;
            this.Add(ncards[i]);
            
        }
    }
    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform);
    }
    public void transAdd(Card _card,int objind,int position)
    {
        ncards[position] = _card;
        _card.transform.SetParent(this.transform);
        _card.transform.SetSiblingIndex(objind);

    }
    public Card Pull(int _position)
    {
        return ncards[_position];
    }
    public int Pullindex(int _position)
    {
        return ncards[_position].transform.GetSiblingIndex();
    }
}
