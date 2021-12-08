using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VolumeBinder : MonoBehaviour
{
    private VisualEffect vfx;
    public AudioManager manager;

    // Start is called before the first frame update
    void Start()
    {
        vfx = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        float[] volumes = manager.volumes;
        for(int i = 0; i < volumes.Length; i ++){
            vfx.SetFloat("vol" + i.ToString(), volumes[i]);
        }
    }
}
