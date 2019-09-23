using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Camera myCamera;

    public GameObject crashWall;

    private void OnTriggerEnter(Collider other)
    {
        Camera.main.enabled = false;
        myCamera.enabled = true;

        crashWall.SetActive(true);
    }
}
