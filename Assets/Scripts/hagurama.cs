using UnityEngine;

public class hagurama : MonoBehaviour
{
    [SerializeField] private float Ratio = 0.1f;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, Ratio));
    }
}
