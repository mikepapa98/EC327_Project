using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public float speed = 0.01f;
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
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
    
}
