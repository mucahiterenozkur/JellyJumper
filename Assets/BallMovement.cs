using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashEffectPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //rb.AddForce(Vector3.up * jumpForce);
        rb.velocity = Vector3.up * jumpForce;
        GameObject splashEffect = Instantiate(splashEffectPrefab, transform.position + new Vector3(0f,-0.24f,0f), transform.rotation);
        splashEffect.transform.SetParent(other.gameObject.transform);
        Destroy(splashEffect, 1f);

        string tagName = other.gameObject.tag;
    }

    
}
