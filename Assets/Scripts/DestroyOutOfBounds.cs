using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if gameObjeect goes out of the player's view it will be destroyed
        if(transform.position.z > topBound || transform.position.x > 20f)
        {
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound || transform.position.x < -20f)
        {
            Destroy(this.gameObject);
            if (GameObject.FindObjectOfType<SpawnManager>().lives > 0)
            {
                GameObject.FindObjectOfType<SpawnManager>().lives -= 1;
                Debug.Log("Lives = " + GameObject.FindObjectOfType<SpawnManager>().lives);
            }
            else if (GameObject.FindObjectOfType<SpawnManager>().lives <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
}
