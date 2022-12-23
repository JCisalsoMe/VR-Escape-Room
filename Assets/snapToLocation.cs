using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapToLocation : MonoBehaviour
{

    private bool grabbed;

    private bool insideSnapZone;

    private bool Snapped;

    public GameObject Green_Key;

    public GameObject SnapRotationReference;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == Green_Key.name)
        {
            insideSnapZone = false;
        }
    }

    // Start is called before the first frame update
    void SnapObject()
    {
     if (grabbed == false && insideSnapZone == true)   
     {
        Green_Key.gameObject.transform.position = transform.position;
        Green_Key.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
        Snapped = true;
     }
    }

    // Update is called once per frame
    void Update()
    {
       grabbed = Green_Key.GetComponent<OVRGrabbable>().isGrabbed;
       SnapObject(); 
    }
}
