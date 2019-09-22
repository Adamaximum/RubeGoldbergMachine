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

        if (Input.GetKey(KeyCode.S))
        {
            if(targetOffsetX > -3)
            {
                targetOffsetX--;
            }
            if (targetOffsetY < 3)
            {
                targetOffsetY++;
            }
            if (Camera.main.transform.rotation.x < 30)
            {
                Camera.main.transform.Rotate(1, 0, 0);
            }
            if (Camera.main.transform.rotation.y < 90)
            {
                Camera.main.transform.Rotate(0, 1, 0);
            }
        }

        //rotate X = 30, Y = 90
        //offset X = -3, Y = 3
    }
}