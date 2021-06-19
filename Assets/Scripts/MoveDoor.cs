using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    //X座標
    [SerializeField] private float MaxX = 0;
    [SerializeField] private float MinX = 0;

    //Y座標
    [SerializeField] private float MaxY = 0;
    [SerializeField] private float MinY = 0;

    [SerializeField] private float Speed = 1;

    [SerializeField] private bool isX =true;

    private bool on = true;
    
    private void FixedUpdate()
    {
        if(isX)
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

        if(!isX)
        {
            if (on)
            {
                transform.Translate(0, Speed, 0);
                if(transform.position.y > MaxY)
                {
                    on = false;
                }
            }
            if (!on)
            {
                transform.Translate(0, -Speed, 0);
                if (transform.position.y < MinY)
                {
                    on = true;
                }
            }

        }
    }

}
