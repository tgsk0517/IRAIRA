﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject wintex;
    [SerializeField] private GameObject deftex;
    [SerializeField] private GameObject delete01;
    [SerializeField] private GameObject delete02;
    [SerializeField] private GameObject Explode;
    private GameObject mpobj;

    //ドラッグ移動
    void OnMouseDrag()
    {
        Vector3 objectPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector3 pointScreen = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objectPoint.z);

        Vector3 pointWorld = Camera.main.ScreenToWorldPoint(pointScreen);
        pointWorld.z = transform.position.z;

        transform.position = pointWorld;
    }

    //消滅＆ゲームオーバーまたはクリア
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Instantiate(Explode,this.transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(delete01);
            Destroy(delete02);
            mpobj = GameObject.FindGameObjectWithTag("MoveMap");
            Destroy(mpobj);
            deftex.SetActive(true);
        }

        if (collision.gameObject.tag == "Clear")
        {
            Destroy(gameObject);
            Destroy(delete01);
            Destroy(delete02);
            mpobj = GameObject.FindGameObjectWithTag("MoveMap");
            Destroy(mpobj);
            wintex.SetActive(true);
        }

    }

}
