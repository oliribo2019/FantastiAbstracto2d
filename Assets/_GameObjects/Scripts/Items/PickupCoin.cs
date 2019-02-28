using UnityEngine;
using System.Collections;

public class PickupCoin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            GameManager.AddPoints(2);
            Destroy(gameObject);
    }
}