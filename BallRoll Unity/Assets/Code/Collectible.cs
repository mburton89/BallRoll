using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CollectibleManager.Instance.HandleCoinCollected();
        Destroy(gameObject);
    }
}
