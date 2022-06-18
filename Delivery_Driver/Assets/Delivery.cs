using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit something");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered something");

    }
}
