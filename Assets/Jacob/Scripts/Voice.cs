using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Voice
{

    public string name;

    public AudioClip clip;

    [Range(0f, 10f)]
    public float volume = 1.0f;

    [HideInInspector]
    public AudioSource source;
}
