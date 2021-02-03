using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRotate : MonoBehaviour
{
   
    [SerializeField]private float Sensitivity=10;

    [System.Obsolete]
    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * Sensitivity * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * Sensitivity * Mathf.Deg2Rad;

       transform.RotateAround(Vector3.up, -rotX);
       transform.RotateAround(Vector3.right, roty);
    }
}
    


