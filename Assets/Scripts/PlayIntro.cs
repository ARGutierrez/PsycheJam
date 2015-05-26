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
	public AudioClip MLG;

    private AudioClip[] clips;
    private int clipCount;

    private AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
		clips = new AudioClip[9]{
			intro01,
			kids,
			intro02,
			chooseClip (intro03),
			chooseClip (intro04),
			chooseClip (intro05),
			intro06,
			chooseClip(intro07),
			MLG
		};

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
                audioSource.Play();
            }
        }
//        else
//        {
//            Destroy(gameObject);
//        }

	
	}
}
