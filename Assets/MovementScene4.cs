using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScene4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float thrust = 2.0f;

    void FixedUpdate()
    {
        if (transform.position.z > 5)
        {
            transform.position += this.transform.forward * thrust * Time.deltaTime;
            if (transform.rotation.y < 180) {
                transform.Rotate(Vector3.up * 2.0f * Time.deltaTime, Space.World);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
