using UnityEngine;
using System.Collections;

public class GhostGen : MonoBehaviour {
    public GameObject ghost;
	// Use this for initialization
	void Start () {

        InvokeRepeating("Generate", 2, (Random.Range(1,1000)%6));
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void Generate()
    {
        GameObject tempGhost = Instantiate(ghost, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as GameObject;
    }
}
