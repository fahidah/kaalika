using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBy180Degrees : MonoBehaviour
{
    float rotationSpeed = 1.0f;

    void OnMouseDrag()
    {
        float rotateOnXaxis = Input.GetAxis("Mouse X") * rotationSpeed;

        transform.Rotate(Vector3.down, rotateOnXaxis);
    }
}
