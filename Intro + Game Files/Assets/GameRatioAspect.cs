using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GameRatioAspect : MonoBehaviour
{
    //ratioAspect: 1 = 1.0 / 1.0 ; 1.77 = 16.0 / 9.00 ; 1.33 = 4.0 / 3.0 and so on
    public float ratioAspect;
 
    private void Start()
    {
        float targetaspect = ratioAspect;
        float windowaspect = (float)Screen.width / (float)Screen.height;
        float scaleheight = windowaspect / targetaspect;
 
        Camera camera = GetComponent<Camera>();
 
        // if scaled height is less than current height, add letterbox
        if (scaleheight < 1.0f)
        {
            Rect rect = camera.rect;
            rect.width = 1.0f;
            rect.height = scaleheight;
            rect.x = 0;
            rect.y = (1.0f - scaleheight) / 2.0f;
            camera.rect = rect;
        }
        else
        { // else add pillarbox
            float scalewidth = 1.0f / scaleheight;
            Rect rect = camera.rect;
            rect.width = scalewidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;
            camera.rect = rect;
        }
    }
}
