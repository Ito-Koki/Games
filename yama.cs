using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yama : MonoBehaviour
{
    GameObject obj;
    GameObject[] cardPrefab = new GameObject[10];
    // Start is called before the first frame update
    public List<Card> cardList = new List<Card>();
    int n;
    void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            if(GrandGameManager.clearpoint > 3)
            {
                cardPrefab[i] = Resources.Load("Prefabs/Card " + i) as GameObject;
                for (int k = 0; k < 4; k++)
                {
                    GameObject cardObj = Instantiate(cardPrefab[i]);
                    Card card = cardObj.GetComponent<Card>();
                    this.Add(card);
                }
                n = 40;
            }
            else
            {
                if (i > 0)
                {
                    cardPrefab[i] = Resources.Load("Prefabs/Card " + i) as GameObject;
                    for (int k = 0; k < 4; k++)
                    {
                        GameObject cardObj = Instantiate(cardPrefab[i]);
                        Card card = cardObj.GetComponent<Card>();
                        this.Add(card);
                    }
                }
                n = 36;
            }


        }
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
