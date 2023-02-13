using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerarotasion : MonoBehaviour
{
    public float direction = 1f;
    public float speed = 5f;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float angle = transform.eulerAngles.y;
            if (angle > 180f) angle -= 360f;
            if ((angle < -100f) || (angle > 100f)) direction *= -1f;
            transform.eulerAngles += 5 * direction * new Vector3(0, -Input.GetAxis("Mouse X"), 0);
        }
    }
}
