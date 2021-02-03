using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterPLacer : MonoBehaviour
{
    // Start is called before the first frame update
    public CubeGen cube;
    private float noOfCubes;
    private float CenterPos;
    [SerializeField] BoxCollider TouchSensor;
    [SerializeField] Camera View;
    private bool done;
   

    private void Update()
    {
        if (!done)
        {
            noOfCubes = cube.HowMany;
            if (noOfCubes != 0)
            {
                Offset();
                TouchSensor.size = new Vector3(noOfCubes, noOfCubes, noOfCubes);
                done = true;
            }
        }
        
       
    }

    void Offset()
    {
        
            CenterPos = (noOfCubes - 1)/2;
       
        
        Vector3 offset;
        Vector3 offsetCam;
        offset = new Vector3(CenterPos,CenterPos,CenterPos);
        offsetCam = new Vector3(CenterPos, CenterPos, -5 * CenterPos-5);
        transform.position = offset;
        View.transform.position = offsetCam;
    }
}
