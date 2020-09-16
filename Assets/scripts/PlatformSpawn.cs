using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject platform;
    public GameObject points;


    Vector3 lastPos;
    float size;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;

        for(int i=0 ; i< 10 ; i++)
        {
            SpawnPlatform(); 
        }

       
    }

    public void StartSpawningPlatform()
    {
         InvokeRepeating ("SpawnPlatform" , 1f , 0.2f);

    }

    // Update is called once per frame
    void Update()
    {
         if (GameManager.instance.gameOver==true)
         {
             CancelInvoke("SpawnPlatform");
         }
    }


     void SpawnPlatform()
     {
        
        int rand = Random.Range(0 ,7);
        if(rand <3)
        {
            SpawnX ();
        }
        else if (rand >= 3)
        {
            SpawnZ();
        }
     }


    void SpawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        Instantiate(platform , pos ,Quaternion.identity);
        
        int rand = Random.Range (0 , 4);
        if (rand < 1)
        {
            Instantiate (points , new Vector3(pos.x ,pos.y +1 , pos.z) , Quaternion.identity);



        }
        
    }

    void SpawnZ()
    {
         Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        Instantiate(platform , pos ,Quaternion.identity);

        int rand = Random.Range (0 , 4);
        if (rand < 1)
        {
           Instantiate (points , new Vector3(pos.x ,pos.y +1 , pos.z) , Quaternion.identity);

        }
    }
}
