using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoorX : MonoBehaviour
{
    [SerializeField] private float MaxX = 0;
    [SerializeField] private float MinX = 0;
    [SerializeField] private float Speed = 1;
    private bool on = true;
    
    private void FixedUpdate()
    {
        if (on)
        {
            transform.Translate(Speed, 0, 0);
            if(transform.position.x > MaxX)
            {
                on = false;
            }
        }
        if (!on)
        {
            transform.Translate(-Speed, 0, 0);
            if (transform.position.x < MinX)
            {
                on = true;
            }
        }
    }

}
