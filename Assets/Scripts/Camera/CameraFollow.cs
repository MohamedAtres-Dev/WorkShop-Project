using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    private void LateUpdate()
    {
        if(playerTransform != null)
            transform.position = playerTransform.position + offset;
    }
}
