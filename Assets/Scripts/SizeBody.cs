using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeHead1 : MonoBehaviour
{
    [Range(0.1f, 5f)]
    public float speed = 3f;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            transform.localScale = new Vector3(transform.localScale.x - 0.1f * speed,
                                                transform.localScale.y - 0.1f * speed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(transform.localScale.x + 0.1f * speed,
                                               transform.localScale.y + 0.1f * speed, 0);
        }



    }
}
