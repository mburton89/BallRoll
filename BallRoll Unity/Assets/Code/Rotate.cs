using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;
    public Vector3 rotation;

    void Update()
    {
        transform.Rotate(rotation * rotateSpeed * Time.deltaTime);
    }
}