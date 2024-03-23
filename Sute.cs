using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sute : MonoBehaviour
{
    List<Card> cardList = new List<Card>();
    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform);
        cardList.Add(_card);
    }
}
