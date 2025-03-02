using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject aimCircle;
    public Rigidbody2D rb;
    public bool Isplay;
    public bool Ispoint;
    // Start is called before the first frame update
    void Start()
    {
        aimCircle.transform.position = new Vector3(0, -2, -1);
        Isplay = true;
        Ispoint = false;
    }

    // Update is called once per frame
    void Update()
    {
        Isplaying();
        Ispointing();
    }

    void CastingPointMove()
    {
        float move_x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(move_x * 8, Input.GetAxis("Vertical") * 8, 0f);
        //rb.velocity = new Vector3(Input.GetAxis("Horizontal") * 8, 0f, 0f);
        if (Isplay == false)
        {
            return;
        }
    }

    void Isplaying()
    {


        if (Isplay == true) ;
        {
            CastingPointMove();

        }

        // else(Isplay = true);
        // {

        // }
    }

    void Ispointing()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");
            Ispoint = true;
            Isplay = false;
        }
        Debug.Log("Ispointing is working");
    }

}
