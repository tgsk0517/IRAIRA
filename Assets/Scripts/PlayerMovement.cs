using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //ドラッグ移動
    void OnMouseDrag()
    {
        Vector3 objectPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector3 pointScreen = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objectPoint.z);

        Vector3 pointWorld = Camera.main.ScreenToWorldPoint(pointScreen);
        pointWorld.z = transform.position.z;

        transform.position = pointWorld;
    }

    //消滅＆ゲームオーバー
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }

}
