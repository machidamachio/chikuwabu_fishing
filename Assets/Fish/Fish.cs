using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public GameObject fishShadow;
    public player p1;
    public GameObject aimCircle;
    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {
       p1 = GameObject.Find("Player").GetComponent<player>();

       aimCircle = GameObject.Find("AimCircle");
    }

    // Update is called once per frame
    void Update()
    {
        if(p1.Ispoint == false)
        {
            FishSwimming();
        }
        if(p1.Ispoint == true)
        {

            FishTargeting();
        }

        
    }

    void FishSwimming()
    {
        // Debug.Log("ϵ( 'Θ' )϶");
        
        transform.Translate(-0.02f,0f,0f);
    }

    void FishTargeting()
    {
        float fishDis = Vector3.Distance(aimCircle.transform.position,transform.position);
        // Debug.Log(fishDis);

        if(fishDis <= 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, aimCircle.transform.position, speed * Time.deltaTime);

            //transform.LookAt(aimCircle.transform.position,Vector3.up);

            Vector3 diff = (aimCircle.gameObject.transform.position - fishShadow.transform.position);

            Vector3 direction = new Vector3 (-1, 0, 0);
            fishShadow.transform.rotation = Quaternion.FromToRotation(direction, diff);
            //Vector3.up
        }
        else
        {
            FishSwimming();
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("当たった物体" + col.gameObject.name);
        if(col.gameObject.tag == "Death_wall")
        {
             Destroy(this.gameObject);

             Debug.Log("当たったンゴ");
        }
    }

}
 