using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    [SerializeField] private float Speed;

    void Update()
    {
        transform.Translate(Speed, 0, 0);
    }
}
