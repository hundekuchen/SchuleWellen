using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveProbe : MonoBehaviour
{
    float deltaDist;
    // Start is called before the first frame update
    void Start()
    {
        deltaDist = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position -= new Vector3(0.0f,0.0f, -deltaDist);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position -= new Vector3(deltaDist, 0.0f, 0.0f);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position -= new Vector3( 0.0f, 0.0f, deltaDist);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position -= new Vector3(-deltaDist, 0.0f, 0.0f);

        }
    }
}
