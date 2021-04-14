using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 3;
    public int jS = 10;
    private Rigidbody2D rigidbody;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", mov * speed);
        float movVertival = Input.GetAxis("Vertical");
        rigidbody.velocity= new Vector3(mov * speed, movVertival * speed, 0);
        float jumpspeed = Input.GetAxis("Jump");
        Debug.Log(jumpspeed);
        if(jumpspeed>0)
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, jS, 0);

        }
        else if(jumpspeed > 0)
        {

        }
    }
}
