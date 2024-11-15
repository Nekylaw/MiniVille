using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public int face;
    Text text;
    [SerializeField] GameObject darkPanel;

    private void Awake()
    {
        text = GetComponentInChildren<Text>();
    }

    public void Throw()
    {
        //utiliser dans player (pour compat avec double throw)
        transform.gameObject.SetActive(true);
        darkPanel.SetActive(true);
        StartCoroutine(Roll());
        
    }

    IEnumerator Roll()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return StartCoroutine(NewFace());
        }
        yield return new WaitForSeconds(1);
        transform.gameObject.SetActive(false);
        darkPanel.SetActive(false);
    }

    IEnumerator NewFace()
    {
        face = Random.Range(0, 7);
        text.text = face.ToString();

        yield return new WaitForSeconds(.1f);
    }
}
