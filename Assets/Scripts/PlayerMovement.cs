using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float movementSpeed;
    
    private float moveVelocity;
    private bool hit = false;
    public static int health = 500;

    public LevelManager levelManager;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
       
        moveVelocity = 0;
       
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Right Arrow is pressed!!");
            moveVelocity += movementSpeed;                
        }

         if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
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
        
        if(health < 100)
        {
            Debug.Log("Game Over!!");
        }
    }

    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Claw") && col.gameObject.tag== "Ghost")
        {
            Destroy(col.gameObject);
        }
        else if(col.gameObject.tag == "Ghost")
        {
            health -= 100;
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "Fence")
        {
            Debug.Log("You win!!!");
            //levelManager.LoadLevel("WinLevel");
        }
    }
    
    void OnCollisionExit2D(Collision2D col)
    {
       
    }
}
