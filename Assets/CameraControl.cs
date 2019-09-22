using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;

    //public Transform followTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 5, target.position.z - 10);

        //if(followTarget != null)
        //{
        //    Vector3 newForwardDirection = 
        //}
    }
}
