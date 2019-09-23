using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRingTrigger : MonoBehaviour
{
    public Light ring;

    // Start is called before the first frame update
    void Start()
    {
        ring = GetComponentInChildren<Light>();
        ring.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        ring.gameObject.SetActive(true);
    }
}
