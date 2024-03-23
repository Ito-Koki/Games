using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Field : MonoBehaviour
{
    List<Card> cardList = new List<Card>();
    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform);
        cardList.Add(_card);
    }
    /*public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        return card;
    }*/
    public void Count()
    {
        for(int i = 0; i < BattleManager.count; i++)
        {
            BattleManager.ptags[i] = transform.GetChild(i).gameObject.tag;
        }
    }
    public void opCount()
    {
        for (int i = 0; i < BattleManager.count; i++)
        {
            BattleManager.optags[i] = transform.GetChild(i).gameObject.tag;
        }
    }
}
