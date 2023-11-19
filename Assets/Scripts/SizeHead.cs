using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeHead : MonoBehaviour
{
    [Range(0.1f, 5f)]
    public float speed = 3f;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            transform.localScale = new Vector3(transform.localScale.x - 0.1f * speed,
                                                transform.localScale.y - 0.1f * speed, 0);
        } else if (Input.GetKey(KeyCode.P))
        {
            transform.localScale = new Vector3(transform.localScale.x + 0.1f * speed,
                                               transform.localScale.y + 0.1f * speed, 0);
        }
        
            
        
    }
















    /*public float speed = 3f;
    Vector3 size;
    

    private bool Button = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Button == true)
        {
            size = transform.localScale;
        }
    }*/
}
