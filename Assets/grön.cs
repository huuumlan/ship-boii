using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grön : MonoBehaviour {

    public Color right;
    public SpriteRenderer rend;


	// Use this for initialization
	void Start ()
    {
        rend.color = right;
       
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            right = rend.color = new Color(0, 0, 1);

        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            right = rend.color = new Color(1, 0, 0);
        }


		
	}
}
