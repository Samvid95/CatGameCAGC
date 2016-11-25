using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float movementSpeed;
    
    private float moveVelocity;
   

   

	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
       
        moveVelocity = 0;
       
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.R))
        {
            Debug.Log("Right Arrow is pressed!!");
            moveVelocity += movementSpeed;                
        }

         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.L))
         {
            Debug.Log("Left Arrow is pressed!!");
            moveVelocity -= movementSpeed;                
         }

        Debug.Log("The movement velocity should be:" + new Vector2(moveVelocity,GetComponent<Rigidbody2D>().velocity.y)); 
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        
    }

    
    void OnCollisionEnter2D(Collision2D col)
    {
        

    }
    
    void OnCollisionExit2D(Collision2D col)
    {
       
    }
}
