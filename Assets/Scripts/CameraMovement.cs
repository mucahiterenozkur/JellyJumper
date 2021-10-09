using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform ballTransform;
    private Vector3 offset;
    public float smoothSpeed;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = Vector3.Lerp(transform.position, offset + ballTransform.position, smoothSpeed);
        transform.position = targetPosition;
    }
}
