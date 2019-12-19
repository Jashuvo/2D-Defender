using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubePlayerScript : MonoBehaviour
{
    public GameObject ground;
    public Rigidbody playerRigid;
    

    
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        
    }

   
    void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {

        playerRigid.velocity = new Vector3(0, 0, -4); 
    }

    public void OnTriggerEnter(Collider collision)
    {
        Debug.Log("collided");
        if (collision.gameObject.tag == "wall")
        {
            Instantiate(ground,new Vector3(0,0,-2),Quaternion.identity);
        }
    }
}
