using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Food")
        {
            this.gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(other.gameObject);
        }
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
            if(GameObject.FindObjectOfType<SpawnManager>().lives > 0)
            {
                GameObject.FindObjectOfType<SpawnManager>().lives -= 1;
                Debug.Log("Lives = " + GameObject.FindObjectOfType<SpawnManager>().lives);
            }
            else if(GameObject.FindObjectOfType<SpawnManager>().lives <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
}
