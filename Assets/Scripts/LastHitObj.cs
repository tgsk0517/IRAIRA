using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastHitObj : MonoBehaviour
{
    [SerializeField] private GameObject MoveMap;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(MoveMap, new Vector3(-15.03f, 3.819303f, -7.235872f), Quaternion.identity);
            Destroy(gameObject);
        }

    }

}
