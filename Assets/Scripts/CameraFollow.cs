using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cube_transform;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = cube_transform.position + offset;
    }
}
