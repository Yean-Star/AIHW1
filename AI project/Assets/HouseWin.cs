using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseWin : MonoBehaviour
{
    private CoinSpawner coin;
    private PlayerPickup pick;
    private void Awake()
    {
        coin = FindObjectOfType<CoinSpawner>();
        pick = FindObjectOfType<PlayerPickup>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && pick.isPick)
        {
            coin.SpawnBlock();
            pick.isPick = false;
            pick.isHappy = true;
        }
    }
}
