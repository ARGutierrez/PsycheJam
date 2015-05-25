using UnityEngine;
using System.Collections;

public class PlaySoundOnCollision : MonoBehaviour {
	public AudioClip[] clips;
	private AudioSource audioSource;
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	AudioClip chooseClip(AudioClip[] array)
	{
		return array[Random.Range(0, array.Length)];
	}
    void OnCollisionEnter()
	{
		audioSource.clip = chooseClip (clips);
		audioSource.Play ();
    }
}
