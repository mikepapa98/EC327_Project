using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //public Transform followTransform;
    public static float mainCamX, mainCamY, mainCamZ;

    // Update is called once per frame
    void FixedUpdate(){
        //this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);
        //transform.Translate(Vector3.forward * (Time.deltaTime*5));
        transform.Translate(0.075f, 0, 0);
        mainCamX = transform.position.x;
        mainCamY = transform.position.y;
        mainCamZ = transform.position.z;
    }
}
