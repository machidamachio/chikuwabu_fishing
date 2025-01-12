using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject aimCircle;

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
        if (Input.GetAxis("Horizontal") == 1f || Input.GetAxis("Horizontal") == -1f) ;
        {
            Debug.Log("Horizontal" + Input.GetAxis("Horizontal"));
            aimCircle.transform.position += new Vector3(Input.GetAxis("Horizontal") * 8 * Time.deltaTime, 0f, 0f);
        }
    }

}
