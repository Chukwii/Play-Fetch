using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool isCounting = true;
    private float timer = 1.5f;
    private float startTime = 1f;

    private void Start()
    {
        InvokeRepeating("allowSpacePress", startTime, timer);
    }
    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press, send dog
        if(isCounting == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                isCounting = true;
            }
        }
        
    }

    void allowSpacePress()
    {
        if (isCounting == true)
        {
            isCounting = false;
        }
    }
}
