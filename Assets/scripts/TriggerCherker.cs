using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCherker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "ball")
        {
            Invoke("FallDown" , 0.5f);
        }
    }



    void FallDown()
    {
        Destroy (transform.parent.gameObject , 2f);
    }

}
