using UnityEngine;
using System.Collections;

public class PlaySoundOnCollision : MonoBehaviour {

    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
    }
}
