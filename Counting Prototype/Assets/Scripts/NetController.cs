using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetController : MonoBehaviour
{
    private float horizontalInput;
    private float verticallInput;
    private Rigidbody netRb;
    [SerializeField] private float movementSpeed = 0.1f;


    void Start()
    {
        netRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticallInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(0, movementSpeed * verticallInput, movementSpeed * horizontalInput);
        transform.Translate(direction * Time.deltaTime, Space.World);
    }
}
