using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_spawner : MonoBehaviour
{
    public GameObject fishShadow;

    public player p1;

    int second = System.DateTime.Now.Second;

    int flag =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        second = System.DateTime.Now.Second;
        if (p1.Ispoint == false)
        {
            FishSpawning();
        }
        

        // Debug.Log(second+"秒");
    }

    void FishSpawning()
    { 
        if(second % 2 == 0 && flag == 0)
        {
            // Debug.Log("スポーン");

            Instantiate(fishShadow,new Vector3(0,0,0),Quaternion.identity);

            flag = 1;

        }

        if(second % 2 == 1 )
        {
            flag = 0;
        }
    }
}
