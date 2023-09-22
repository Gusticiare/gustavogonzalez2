using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    private void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "cube")
        {
            Destroy(other.gameObject);
        }
    }
    
}
