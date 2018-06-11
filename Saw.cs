using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour 
{
    public GameObject respawn;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            collider.transform.position = respawn.transform.position;
        }
    }
	void Update () 
    {
        transform.Rotate(new Vector3(0f, 0f, -3f));
	}
}
