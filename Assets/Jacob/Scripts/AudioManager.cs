using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public Sound[] sounds;

    //Singleton pattern
    public static AudioManager instance;

    void Awake ()
	{
		//Singleton pattern
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
			return;
        }

        foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;

			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
            s.source.loop = s.loop;
			s.source.spatialBlend = s.spatialBlend;
        }
	}


	//To call:
	//FindObjectOfType<AudioManager>().Play("clip_name");
	//
	public void Play (string name)
	{
		Sound s = Array.Find(sounds, sounds => sounds.name == name);

		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found");
			return;
		}
		s.source.Play();
	}
}
