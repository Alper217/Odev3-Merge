using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotationOnObstacle : MonoBehaviour
{
    private float rotationSpeed = 500f;
    void Update()
    {
        transform.Rotate(0f,rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);
    }
}
