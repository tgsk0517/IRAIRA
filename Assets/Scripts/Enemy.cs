using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
        }
    }

}
