using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D coll)
    // {
    //     if (coll.gameObject.CompareTag("Players"))
    //     {
    //         coll.gameObject.transform.SetParent(transform);
    //     }
    // }
    // private void OnCollisonExit2D(Collision2D coll)
    // {
    //     if (coll.gameObject.CompareTag("Players"))
    //     {
    //         coll.gameObject.transform.SetParent(null);
    //     }
    // }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Players"))
        {
            coll.gameObject.transform.SetParent(transform);
        }
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Players"))
        {
            coll.gameObject.transform.SetParent(null);
        }
    }
}