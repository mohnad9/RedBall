using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick joystick;
    public Rigidbody2D rb;

    public float Speed = 10;


    void Update()
    {
        if(joystick.Horizontal > 0)
        {
            rb.position += Vector3.right * Speed * Time.fixedDeltaTime;

        }
       
       else if(joystick.Horizontal < 0)
        {
            rb.position -= Vector3.right * Speed * Time.fixedDeltaTime;


        }
    }
}
