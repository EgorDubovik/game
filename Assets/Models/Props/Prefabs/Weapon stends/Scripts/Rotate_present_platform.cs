using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_present_platform : MonoBehaviour
{
    [SerializeField] public float speed = 12f; // скорость

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0, Space.Self);
    }
}
