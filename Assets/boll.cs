using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    public SpriteRenderer rend;
    public Transform other;
    public Color left;
    public Color right;
    public float Timer;
    private float variabel = 1;
    public float randomspeed;
    public float newposition;
    public bool halafart;


    [Range(-720, 720)]
    public float rotationSpeed;

    // Use this for initialization
    void Start()
    {
        rend.color = left;
        rend.color = new Color(1f, 0.5f, 0.3f);
        transform.position = new Vector3(Random.Range(-9, 4), Random.Range(-5, 1)); // startar på en random position varje game

        randomspeed = Random.Range(5, 10); //randomiserar hastighet
        halafart = false; //halspeed av
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(2 * Time.deltaTime, 0, 0, Space.Self);


        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.Translate(randomspeed / -2 * Time.deltaTime, 0, 0, Space.Self); // tryck S så halveras speeden
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -rotationSpeed / 2 * Time.deltaTime); // tryck A för vänstersväng

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime); // tryck D för högersväng


        }
        Vector3 newposition = transform.position;
        if (newposition.x < -9.4f || newposition.x > 9.4f)
        {
            newposition.x = -newposition.x;
        }

        if (newposition.y < -4.98f || newposition.y > 5.01f)
        {
            newposition.y = -newposition.y;

        }
        transform.position = newposition;

        Timer += Time.deltaTime;
        if (Timer > variabel && Timer < variabel + 0.2)
        {
            Debug.Log(string.Format("timer"));

            print(Timer);
            variabel = (variabel + 1);
        }
    }

}

