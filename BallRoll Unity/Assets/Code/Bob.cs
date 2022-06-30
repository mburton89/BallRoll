using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bob : MonoBehaviour
{
    float initialYPosition;
    public float distanceToMoveY;
    public float secondsToBob = 1;

    void Start()
    {
        initialYPosition = transform.position.y;
        StartCoroutine(BobCo());
    }

    private IEnumerator BobCo()
    {
        transform.DOMoveY(initialYPosition + distanceToMoveY, secondsToBob).SetEase(Ease.InOutQuad);
        yield return new WaitForSeconds(secondsToBob);
        transform.DOMoveY(initialYPosition - distanceToMoveY, secondsToBob).SetEase(Ease.InOutQuad);
        yield return new WaitForSeconds(secondsToBob);
        StartCoroutine(BobCo());
    }
}