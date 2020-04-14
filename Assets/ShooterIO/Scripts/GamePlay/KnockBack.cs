using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 moveDirection;
    public float knockBackForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Attack")
        {
            rb.AddForce(moveDirection * -knockBackForce);
        }        
    }
}
