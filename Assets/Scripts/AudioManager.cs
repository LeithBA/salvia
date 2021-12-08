using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioAnalyzer[] sources;
    public float[] volumes;

    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponentsInChildren<AudioAnalyzer>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i< sources.Length; i++){
            float[] samples = sources[i].samples;
            volumes[i] = 0f;
            for(int j = 0; j < samples.Length; j++){
                volumes[i] += samples[j];
            }
            volumes[i] /= (float)samples.Length;
            volumes[i] = Mathf.Abs(volumes[i]) * 100000f;
        }
    }
}
