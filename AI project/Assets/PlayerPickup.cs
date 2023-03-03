using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public bool isPick = false;
    public bool isHappy = false;
    public GameObject coin;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            isPick = true;
            isHappy = false;
        }
    }
}
