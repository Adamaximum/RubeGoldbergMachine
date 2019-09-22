using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Camera myCamera;

    private void OnTriggerEnter(Collider other)
    {
        Camera.main.enabled = false;
        myCamera.enabled = true;
    }
}
