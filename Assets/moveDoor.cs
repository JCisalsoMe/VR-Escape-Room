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
        if (moveDoor() == true && unlocked == false)
        {
            Debug.Log(moveDoor());

            gameObject.AddComponent<ConstantForce>().force = new Vector3(1500f,0f,0f);
            unlocked = true;
        }
    }

    private bool moveDoor () {
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
