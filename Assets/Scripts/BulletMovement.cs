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
        this.gameObject.transform.position = Vector3.MoveTowards(transform.position, pl.transform.position, Speed * Time.deltaTime);
    }
}
