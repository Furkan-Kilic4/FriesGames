using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    private float horizontalLeftBoundary = -8.37f;
    private float horziontalRightBoundary = 8.37f;
    void Update()
    {
        if (transform.position.x < horizontalLeftBoundary)
        {

            transform.position = new Vector3(horizontalLeftBoundary, transform.position.y, transform.position.z);
        }

        if(transform.position.x >horziontalRightBoundary)
        {
            transform.position = new Vector3(horziontalRightBoundary, transform.position.y, transform.position.z);
        }        
    }
}
