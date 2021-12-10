using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXVisibility : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().enabled = false;
    }

    public void Visible()
    {
        GetComponent<Renderer>().enabled = true;
    }

    public void Invisible()
    {
        GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
