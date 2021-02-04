using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGen : MonoBehaviour
{
    [SerializeField] GameObject cube;
    public int HowMany;
    [SerializeField] private GameObject Rows;
    [SerializeField] private GameObject Slabs;
    [SerializeField] private GameObject MainCube;
    private bool done;
    // Start is called before the first frame update
   
    private void Update()
    {
        if (HowMany != 0 && !done)
        {
            GiantCube();
            done = true;
        }

       
    }


    void GiantCube()
    {
        for (int k = 0; k < HowMany; k++)
        {
            Vector3 temp = transform.position;
            temp.x = transform.position.x + k;
            Instantiate(cube, temp, Quaternion.identity, Rows.transform);

        }


        for (int k = 1; k < HowMany; k++)
        {
            Vector3 temp = Rows.transform.position;
            temp.z = Rows.transform.position.z + k;
            Instantiate(Rows, temp, Quaternion.identity, Slabs.transform);

        }
        Rows.transform.SetParent(Slabs.transform);

        for (int k = 1; k < HowMany; k++)
        {
            Vector3 temp = Slabs.transform.position;
            temp.y = Slabs.transform.position.y + k;
            Instantiate(Slabs, temp, Quaternion.identity, MainCube.transform);
        }

        Slabs.transform.SetParent(MainCube.transform);
    }
    
}
