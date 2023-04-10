using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjeto : MonoBehaviour
{
    private Vector3 mOffset;
    private float mzCoords;

    void OnMouseDown()
    {
        mzCoords = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; 
        mOffset = gameObject.transform.position - getMouseWorldPos();
    }

    private Vector3 getMouseWorldPos()
    {
        //Coordenadas X,Y
        Vector3 mousePoint = Input.mousePosition;

        //Coordenadas Z
        mousePoint.z = mzCoords;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = getMouseWorldPos() +mOffset;
    }
}
