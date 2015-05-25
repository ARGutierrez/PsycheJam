using UnityEngine;
using System.Collections;

public class DeleteExplosion : MonoBehaviour {

    public ParticleSystem ps1;
    public ParticleSystem ps2;

	// Use this for initialization
	void Start () {
        Invoke("Delete", 2f);
	}
	
	// Update is called once per frame
	void Update () {
        /*if (!ps1.IsAlive() && !ps2.IsAlive())
        {
            Debug.Log("destroying");
            Destroy(gameObject);
        }*/
	}

    void Delete()
    {
        Destroy(gameObject);
    }
}
