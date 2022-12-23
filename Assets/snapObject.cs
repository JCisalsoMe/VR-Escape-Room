using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapObject : MonoBehaviour
{

    public GameObject SnapLocation;

    public GameObject SnapZoneKeys;

    public bool isSnapped;

    private bool objectSnapped;

    private bool grabbed;

    // Update is called once per frame
    void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;

        objectSnapped = SnapLocation.GetComponent<SnapToLocation>().Snapped;

        if (objectSnapped == true)
        {
            GetComponent<Rigidbody>(); isKinematic = true;
            transform.SetParent(rocket.transform);
            isSnapped = true;
        }

        if (objectSnapped == false && grabbed == false) {
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
