using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SparseUpdate());
    }

    IEnumerator SparseUpdate()
    {
        yield return new WaitForSeconds(4);
        while(true)
        {
            yield return null;
            transform.Translate(0.01f, 0, 0);
            if (Input.GetKey ("escape"))
            {
                 Application.Quit();
            }
        }
    }
}

