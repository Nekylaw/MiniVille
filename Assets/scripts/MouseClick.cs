using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit)
            {
                if (hit.transform.tag == "Carte")
                {
                    //smth
                }
            }
        }
    }
}
