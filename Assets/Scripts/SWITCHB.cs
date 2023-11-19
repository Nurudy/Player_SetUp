using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SWITCHB : MonoBehaviour
{
    public GameObject[] BODY;

    int index;

    private void Start()
    {
        index = 0; 
    }

    private void Update()
    {
        if (index >= 3)
            index = 3;

        if (index < 0)
            index = 0;

        if ( index == 0)
        {
            BODY[0].gameObject.SetActive(true);
        }
    }

    public void Next2()
    {
        index += 1;

        for (int i = 0; i < BODY.Length; i++)
        {
            BODY[i].gameObject.SetActive(false);
            BODY[index].gameObject.SetActive(true);
        }

        Debug.Log(index);
    }

    public void Previous2()
    {
        index -= 1;

        for(int i = 0; i < BODY.Length; i++)
        {
            BODY[i].gameObject.SetActive(false);
            BODY[index].gameObject.SetActive(true);
        }

        Debug.Log(index);
    }


}
