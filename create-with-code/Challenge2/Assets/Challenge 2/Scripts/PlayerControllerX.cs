using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float cooldown = 1.5f;
    private float timeSince = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            float current = Time.time;

            if(current - timeSince >= cooldown)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeSince = current;
            }
        }
    }
}
