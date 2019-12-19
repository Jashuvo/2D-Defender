using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    public GameObject[] enimies;
    public GameObject spawnEnemy;
    private int spawnRate;
    private int enemyInScene;
    private float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 8;
        spawnDelay = 0.7f;
        StartCoroutine( Spawn());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Spawn()
    {

        if(enemyInScene < 8)
        {
            for (int i = 0; i < spawnRate; i++)
            {
                GameObject newEnemy = Instantiate(enimies[0]);
                newEnemy.transform.position = spawnEnemy.transform.position;
                enemyInScene +=1;
                yield return new WaitForSeconds(spawnDelay);
            }
            StartCoroutine(Spawn());
            Debug.Log(enemyInScene);
        }

    }

}
