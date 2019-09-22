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
    }
}
