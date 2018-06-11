using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Unit
{
    private float speed = 6.0f;
    private void Awake()
    {

    }
    private void Start()
    {

    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Arrow arrow = collider.GetComponent<Arrow>();
        if (arrow)
            ReceiveDamage();
    }
}
