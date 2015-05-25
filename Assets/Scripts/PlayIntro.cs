using UnityEngine;
using System.Collections;

public class PlayIntro : MonoBehaviour {


    public AudioClip intro01;
    public AudioClip intro02;
    public AudioClip[] intro03;
    public AudioClip[] intro04;
    public AudioClip[] intro05;
    public AudioClip intro06;
    public AudioClip[] intro07;
    public AudioClip kids;

    private AudioClip[] clips;
    private int clipCount;

    private AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        clips = new AudioClip[8];
        clips[0] = intro01;
        clips[1] = intro02;
        clips[2] = chooseClip(intro03);
        clips[3] = chooseClip(intro04);
        clips[4] = chooseClip(intro05);
        clips[5] = intro06;
        clips[6] = chooseClip(intro07);
        clips[7] = kids;

        audioSource.Play();
        
	}

    AudioClip chooseClip(AudioClip[] array)
    {
        return array[Random.Range(0, array.Length)];
    }
	
	// Update is called once per frame
	void Update () {
        if (clipCount < clips.Length)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = clips[clipCount++];
                //clipCount++;
                audioSource.Play();
            }
        }
        else
        {
            Destroy(gameObject);

        }

	
	}
}
