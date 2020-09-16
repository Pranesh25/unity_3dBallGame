using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;
    public float lerpRate;  // rate by which camera the camera will changge its positon to follow the ball
    public bool gameOver ;



    // Start is called before the first frame update
    void Start()
    {
      offset = ball.transform.position -  transform.position;
      gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            Follow();
        }
        {
            
        }
    }


    void Follow()
    {
        Vector3 pos = transform.position;
        //Vector3 targetPos = transform.position + offset;
        Vector3 targetPos = ball.transform.position - offset;
        pos = Vector3.Lerp(pos , targetPos , lerpRate * Time.deltaTime);
        transform.position = pos;
    }
}
