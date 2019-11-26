using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Transform[] wayPoints;
    public Transform exitPoint;
    public int target;
    public float navigationTime;
    // Start is called before the first frame update
    void Start()
    {
        target = 0;
        navigationTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (wayPoints.Length > target)
        {
            navigationTime = Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, wayPoints[target].position, navigationTime);
        }

        Debug.Log(target);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "CheckPoint")
        {
            target+=1;
            Debug.Log("Collide");
        }
        if(col.gameObject.tag == "ExitPoint")
        {
            Destroy(gameObject);
        }
    }
}
