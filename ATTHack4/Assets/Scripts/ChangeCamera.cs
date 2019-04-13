using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Vector3 newPos;
    public Vector3 oldPos;
    public bool cameraMoved = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            if (!cameraMoved)
            {
                this.transform.position = newPos;
                cameraMoved = true;
            }
            else
            {
                this.transform.position = oldPos;
                cameraMoved = false;
            }

        }
        
    }
}
