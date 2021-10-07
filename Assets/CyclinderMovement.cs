using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclinderMovement : MonoBehaviour
{
    public float rotateSpeed;
    private float moveXAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveXAxis = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, moveXAxis * rotateSpeed * Time.deltaTime, 0f);
        }
    }
}
