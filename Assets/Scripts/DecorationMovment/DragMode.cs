﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMode : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    void OnMouseDown()
    {
        Debug.Log("Dragging...");
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
}
