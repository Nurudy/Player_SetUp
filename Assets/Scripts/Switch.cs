using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public GameObject[] HEAD;

    int index;

    private void Start()
    {
        index = 0; 
    }

    private void Update()
    {
        if (index >= 3) index = 4;

        if (index < 0) index = 0; 

        if (index == 0)
        {
            HEAD[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {
        index += 1;

        for (int i = 0; i < HEAD.Length; i++)
        {
            HEAD[i].gameObject.SetActive(false);
            HEAD[index].gameObject.SetActive(true);
        }

        Debug.Log(index);
    }

    public void Previous()
    {
        index -= 1;

        for(int i = 0; i < HEAD.Length; i++)
        {
            HEAD[i].gameObject.SetActive(false);
            HEAD[index].gameObject.SetActive(true);
        }

        Debug.Log(index);
    }
}
