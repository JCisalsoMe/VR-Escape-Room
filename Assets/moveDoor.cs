using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDoor : MonoBehaviour
{
    
    public GameObject[] Star_Door;

    private bool keyAdded;

    private bool unlocked = false;

    // Update is called once per frame
    void Update()
    {
        if (Star_Door() == true && unlocked == false)
        {
            Debug.Log(Star_Door());

            gameObject.AddComponent<ConstantForce>().force = new Vector3(1500f,0f,0f);
            unlocked = true;
        }
    }

    private bool Star_Door () {
        for (int i = 0; i < Star_Door.length; i++)
        {
            partAdded = Star_Door[i].GetComponent<SnapObject>().isSnapped;
            if (partAdded == false)
            {
                return false;
            }
        }
        return true;
    }
}
