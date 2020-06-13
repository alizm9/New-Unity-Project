using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool Grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetCompornent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.position += new Vector3(0.1f, 0, 0);

        }
    }
}
