using UnityEngine;
using System.Collections;

public class SoundManagerScript : MonoBehaviour 
{
	public AudioClip knifeHitAudio;
	public AudioClip buttonAudio;
	public AudioClip fruitHitAudio;
	public AudioClip gameoverAudio;
	public AudioClip fruitSpawnAudio;

	public static AudioSource knifeHitAudioSource;
	public static AudioSource buttonAudioSource;
	public static AudioSource fruitHitAudioSource;
	public static AudioSource gameoverAudioSource;
	public static AudioSource fruitSpawnAudioSource;

	AudioSource AddAudio(AudioClip clip, bool playOnAwake,bool loop,float volume)
	{
		AudioSource audioSource = this.gameObject.AddComponent<AudioSource> ();
		audioSource.clip = clip;
		audioSource.playOnAwake = playOnAwake;
		audioSource.loop = loop;
		audioSource.volume = volume;
		return audioSource;
	}

	void Awake () 
	{
		knifeHitAudioSource = AddAudio (knifeHitAudio,false, false,1.0f);
		buttonAudioSource = AddAudio (buttonAudio,false, false, 1.0f);
		fruitHitAudioSource = AddAudio (fruitHitAudio,false, false, 1.0f);
		gameoverAudioSource = AddAudio (gameoverAudio,false, false, 1.0f);
		fruitSpawnAudioSource = AddAudio (fruitSpawnAudio,false, false,1f);
	}
}
