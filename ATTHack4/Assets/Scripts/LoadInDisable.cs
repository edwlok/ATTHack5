using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitDisable());
    }

    // Update is called once per frame
    IEnumerator waitDisable()
    {
        
        yield return new WaitForSeconds(3f);
        this.gameObject.SetActive(false);
    }
}
