using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_spawner : MonoBehaviour
{
    public GameObject fishShadow;

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

        FishSpawning();

        // Debug.Log(second+"秒");
    }

    void FishSpawning()
    { 
        if(second % 3 == 0 && flag == 0)
        {
            // Debug.Log("スポーン");

            Instantiate(fishShadow,new Vector3(0,0,0),Quaternion.identity);

            flag = 1;

        }

        if(second % 3 == 1 )
        {
            flag = 0;
        }
    }
}
