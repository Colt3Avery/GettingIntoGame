using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    private float outOfBoundsN = 30.0f;
    private float outOfBoundsS = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= outOfBoundsN)
        {
            Destroy(gameObject);
        }

        if (transform.position.z <= outOfBoundsS)
        {
            Destroy(gameObject);
        }
    }
}
