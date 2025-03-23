using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_manager : MonoBehaviour
{
    public GameObject fishShadow;

    public player p1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // if(p1.Isplay == true)
        // {
        //     FishSwimming();
        // }


    }

    // void FishSwimming()
    // {
    //     // Debug.Log("ϵ( 'Θ' )϶");
        
    //     fishShadow.transform.Translate(-0.02f,0f,0f);
    // }

    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     Debug.Log("当たった物体" + col.gameObject.name);
    //     if(col.gameObject.tag == "Death_wall")
    //     {
    //          Destroy(gameObject);

    //          Debug.Log("当たったンゴ");
    //     }
    // }

}
 