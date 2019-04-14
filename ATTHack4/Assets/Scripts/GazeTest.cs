using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeTest : MonoBehaviour
{
    public Transform cameraTransform;
    public GameObject currentImg;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float length = 100.0f;
        RaycastHit hit;
        Vector3 rayDirection = cameraTransform.TransformDirection(Vector3.forward);
        Vector3 rayStart = cameraTransform.position + rayDirection;    
        if (Physics.Raycast(rayStart, rayDirection, out hit, length))
        {
            if (hit.collider.tag == "Object")
            {                
                if (OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                {
                    Vector3 newPos = hit.transform.position;
                    newPos.y += 2f;

                    hit.transform.position = newPos;
                } 
                // Do stuff
            }

            if (hit.collider.tag == "Camera")
            {
                if (OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                {
                    this.transform.position = hit.transform.position;
                    if (hit.transform.gameObject.name != "MiddleLocation")
                    {
                        this.transform.LookAt(GameObject.Find("MiddleSword").transform);
                    }
                    //this.transform.rotation = hit.transform.rotation;
                }
                // Do stuff
            }

            if (hit.collider.tag == "Player")
            {
                if (OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                {
                    MeshRenderer temp = this.transform.Find("NameCard").GetComponent<MeshRenderer>();
                    temp.enabled = true;
                }
                // Do stuff
            }
        }
    }
}
