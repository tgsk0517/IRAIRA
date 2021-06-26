using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    [SerializeField] GameObject pl;

    void Update()
    {

        if (pl == null)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.transform.position = Vector3.MoveTowards(transform.position, pl.transform.position, Speed * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

}
