using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float movementSpeed;
    
    private float moveVelocity;
    private bool hit = false;

   

	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
       
        moveVelocity = 0;
       
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.R))
        {
            //Debug.Log("Right Arrow is pressed!!");
            moveVelocity += movementSpeed;                
        }

         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.L))
         {
            //Debug.Log("Left Arrow is pressed!!");
            moveVelocity -= movementSpeed;                
         }

        //Debug.Log("The movement velocity should be:" + new Vector2(moveVelocity,GetComponent<Rigidbody2D>().velocity.y)); 
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hit = true;
            GetComponent<Animator>().SetBool("Fight", true);
            Debug.Log(GetComponent<Animator>().GetBool("Fight"));
            GetComponent<Animator>().Play("Claw");
            Debug.Log(GetComponent<Animator>().GetBool("Fight"));
            GetComponent<Animator>().SetBool("Fight", false);

        }
        hit = false;
        
        
    }

    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Claw") && col.gameObject.tag== "Ghost")
        {
            Destroy(col.gameObject);
        }
    }
    
    void OnCollisionExit2D(Collision2D col)
    {
       
    }
}
