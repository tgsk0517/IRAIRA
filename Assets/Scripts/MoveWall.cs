using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField] private float Ratio = 1;
    [SerializeField] private float MaxScale = 2f;

    private bool wallbool = true;

    private void FixedUpdate()
    {
        if (wallbool)
        {
            transform.localScale += new Vector3(0, Ratio, 0);
            if(gameObject.transform.localScale.y > MaxScale)
            {
                wallbool = false;
            }
        }
        else if (wallbool == false)
        {
            transform.localScale += new Vector3(0, -Ratio, 0);
            if(gameObject.transform.localScale.y < 0.5f)
            {
                wallbool = true;
            }
        }
    }

}
