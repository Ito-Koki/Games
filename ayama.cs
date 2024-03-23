using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ayama : MonoBehaviour
{
    GameObject obj;
    GameObject[] cardPrefab = new GameObject[3];
    // Start is called before the first frame update
    public List<Card> cardList = new List<Card>();
    void Awake()
    {
        for (int i = 0; i < 3; i++)
        {
            cardPrefab[i] = Resources.Load("Prefabs/Card " + (10+i)) as GameObject;
            for (int k = 0; k < 4; k++)
            {
                GameObject cardObj = Instantiate(cardPrefab[i]);
                Card card = cardObj.GetComponent<Card>();
                this.Add(card);
            }

        }
        int n = 12;
        while (n > 1)
        {
            n--;
            int k=UnityEngine.Random.Range(0, n+1);
            Card tmp = cardList[k];
            cardList[k] = cardList[n];
            cardList[n] = tmp;
        }
    }
    void Add(Card _card)
    {
        _card.transform.SetParent(this.transform);
        cardList.Add(_card);
    }
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        return card;
    }
}
