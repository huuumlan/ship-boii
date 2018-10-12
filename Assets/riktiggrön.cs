using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class riktiggrön : MonoBehaviour
{
    public Color left;
    public SpriteRenderer rend;

    // Use this for initialization
    void Start()
    {

        rend.color = left;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            left = rend.color = new Color(0, 1, 0);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            left = rend.color = new Color(1, 0, 0);
        }



    }


}
