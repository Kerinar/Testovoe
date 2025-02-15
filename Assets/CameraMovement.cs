using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float _rotationX = 0f;
    private float _rotationY = 0f;

    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        float mouseX = Input.GetAxis("Mouse X");

        _rotationY -= mouseY; //Vertical
        _rotationX += mouseX; //Horizontal

        transform.parent.Rotate(Vector3.up * mouseX);

        _rotationY = Mathf.Clamp(_rotationY, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_rotationY, 0f, 0f);
    }
}
