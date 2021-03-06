using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTarget : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(player.position.y>transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y,transform.position.z);
        }
        if (player.position.y < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }
}
