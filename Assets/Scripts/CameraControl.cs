using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;

    //public Transform followTarget;

    public float targetOffsetX;
    public float targetOffsetY;
    public float targetOffsetZ;

    //public bool camShift;
    //float rotateX;
    //float rotateY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x + targetOffsetX, target.position.y + targetOffsetY, target.position.z + targetOffsetZ);

        //if(followTarget != null)
        //{
        //    Vector3 newForwardDirection = 
        //}

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    camShift = true;
        //}
        //if (camShift == true)
        //{
        //    if (targetOffsetX > -3)
        //    {
        //        targetOffsetX -= 0.1f;
        //    }
        //    if (targetOffsetY < 3)
        //    {
        //        targetOffsetY += 0.1f;
        //    }
            
        //    rotateX += 0.01f;
        //    rotateY += 0.01f;
        //    if (Camera.main.transform.rotation.x != 30)
        //    {
        //        Camera.main.transform.Rotate(rotateX, 0, transform.rotation.z);
        //    }
        //    if (Camera.main.transform.rotation.y != 90)
        //    {
        //        Camera.main.transform.Rotate(0, rotateY, transform.rotation.z);
        //    }
        //}

        //rotate X = 30, Y = 90
        //offset X = -3, Y = 3
    }

    void FailedExperiment()
    {

    }
}