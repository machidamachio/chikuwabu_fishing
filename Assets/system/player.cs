using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject aimCircle;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        aimCircle.transform.position = new Vector3(0, -2, -1);
    }

    // Update is called once per frame
    void Update()
    {
        CastingPointMove();
    }

    void CastingPointMove()
    {   
        Debug.Log("Vertical" + Input.GetAxis("Vertical"));
        float move_x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(move_x * 8, Input.GetAxis("Vertical") * 8, 0f);

        Debug.Log("Horizontal" + Input.GetAxis("Horizontal"));
        //rb.velocity = new Vector3(Input.GetAxis("Horizontal") * 8, 0f, 0f);

    }

}
