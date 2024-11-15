using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.GPUSort;

public class Player : MonoBehaviour
{
    public bool isAI;
    public int money = 3;
    [SerializeField] public List<Card> cards;
    [SerializeField] public List<GameObject> dices;

    [HideInInspector]
    public List<GameObject> monuments = new();
    public bool reroll = false;
    public bool purshasing = false;

    private void Update()
    {
        if(purshasing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit)
                {
                    if (hit.transform.tag == "Purshasable")
                    {
                        cards.Add(hit.collider.gameObject.GetComponent<Card>()); // puis changer coordonnées ou enlever de pile puis creer gameobject dans liste
                        purshasing = false;
                    }
                }
            }
        }
    }

    public void Dice()
    {
        dices[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        dices[0].GetComponent<Dice>().Throw();
    }

    public void DoubleDice()
    {
        if (dices.Count > 1)
        {
            dices[0].GetComponent<RectTransform>().anchoredPosition = new Vector2(-70, 0);
            dices[0].GetComponent<Dice>().Throw();
            dices[1].GetComponent<RectTransform>().anchoredPosition = new Vector2(70, 0);
            dices[1].GetComponent<Dice>().Throw();
        }
        else
        {
            Dice();
        }
    }
}
