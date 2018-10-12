using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    public SpriteRenderer rend;
    public Transform other;
    public Color left;
    public Color right;

    public float newposition;


    [Range(-720, 720)]
    public float rotationSpeed;

    // Use this for initialization
    void Start()
    {
        rend.color = left;
        rend.color = new Color(1f, 0.5f, 0.3f);

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(2 * Time.deltaTime, 0, 0, Space.Self);


        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.Translate(1 * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);


        }
        Vector3 newposition = transform.position;
        if (newposition.x < -9.4f || newposition.x > 9.4f)
        {
            newposition.x = -newposition.x;
        }

        if (newposition.y < - 4.98f || newposition.y > 5.01f)
        {
            newposition.y = -newposition.y;

        }
        transform.position = newposition;
    }

}

