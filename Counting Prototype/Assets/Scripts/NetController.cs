using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetController : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    private float verticallInput;
    private Rigidbody netRb;
    [SerializeField] private float movementSpeed;


    void Start()
    {
        netRb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticallInput = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(0, verticallInput, horizontalInput);
        netRb.velocity = (direction) * movementSpeed * Time.fixedDeltaTime;

        transform.rotation = Quaternion.Euler(0, 90, -90 * Mathf.InverseLerp(-1f, 11f, transform.position.z));
    }
}
