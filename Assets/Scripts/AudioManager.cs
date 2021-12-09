using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioAnalyzer[] sources;
    public float[] volumes;

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < sources.Length; i++){
            sources[i].Refresh();
            float[] samples = sources[i].samples;
            // Debug.Log(volumes.Length + " - " + sources.Length);
            // volumes[i] = 0f;
            float v = 0f;
            for(int j = 0; j < samples.Length; j++){
                v += samples[j] * samples[j];
            }
            v /= (float)samples.Length;
            v = Mathf.Sqrt(v) * 10f;

            volumes[i] =  Mathf.Lerp(volumes[i], v,0.5f);
            // volumes[i] = Mathf.Log10(volumes[i] * 0.1f);
            // volumes[i] = 1f - Mathf.Abs(Mathf.Clamp(volumes[i], -1f, 0f));
        }
    }
}
