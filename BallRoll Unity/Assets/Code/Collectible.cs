using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SoundManager.Instance.PlayCollectSound();
        CollectibleManager.Instance.IncrementCollectedCoinCount();
        Destroy(gameObject);
    }
}
