using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bul = Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody rb = bul.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward*50;
        }
    }
}
