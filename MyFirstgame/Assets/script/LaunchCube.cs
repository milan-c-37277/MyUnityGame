using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");
            rb.AddForce(0, 5.0f, 0, ForceMode.Impulse);
        }
    }
}
