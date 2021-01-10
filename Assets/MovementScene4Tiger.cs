using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScene4Tiger : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(7f);

        GetComponent<Animator>().Play("idle");
    }

    public float thrust = 2.0f;

    void FixedUpdate()
    {
        if (transform.position.z < 2)
        {
            transform.position += this.transform.forward * thrust * Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
