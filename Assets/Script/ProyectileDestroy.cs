using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileDestroy : MonoBehaviour
{
    public float topBound = 22;
    public float lowerBound = -22;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if ( transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
