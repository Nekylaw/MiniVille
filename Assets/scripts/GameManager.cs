using NUnit.Framework;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private GameManager() {}

    //private Player[] players = new Player[] { new Player, new Player};

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
}
