using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_red : MonoBehaviour
{

    public GameObject objToSpawn;
    public float timeLeft, originalTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft-=Time.deltaTime;
        if(timeLeft<=0)
        {
            SpawnIt();

            timeLeft=originalTime;
        }

        if(Input.GetButtonDown("LTD_ButtonRed"))
        {
            SpawnIt();
        }

        void SpawnIt()
        {
            Instantiate(objToSpawn, transform.position, Quaternion.indentity);
        }
    }
}
