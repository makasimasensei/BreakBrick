using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float speedh = 1.5f;
    public float speedv = 0.5f;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(speedh * Time.deltaTime * new Vector3(h, 0, 0));
        transform.Translate(speedv * Time.deltaTime * new Vector3(0, v, 0));
    }
}
