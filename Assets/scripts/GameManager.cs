using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Rendering.GPUSort;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private GameManager() {}

    [SerializeField] GameObject[] players;

    private void Awake()
    {
        if (instance == null)
        {
            instance = new GameManager();
        }
    }

    public void Run()
    {
        //faire les trucs mais il faut le reste avant
        
    }

    public bool GetOtherPlayer(GameObject player, out GameObject otherPlayer)
    {   
        otherPlayer = null;
        foreach (GameObject p in players)
        {
            if (p != player)
                otherPlayer = p;
                return true;
        }
        return false;
    }

    public void activateCards(int diceRoll, GameObject activePlayer)
    {
        Player player = activePlayer.GetComponent<Player>();
        foreach (var card in player.cards)
        {
            /*if (card.info.diceValue1 == diceRoll || card.info.diceValue2 == diceRoll)
            {
                // Activation selon le type de carte
                if (card.info.color != "monument")
                {
                    GameObject otherPlayer;
                    GetOtherPlayer(activePlayer, out otherPlayer);
                    card.Effect(player, otherPlayer.GetComponent<Player>());
                }
            }*/
        }
    }
}
