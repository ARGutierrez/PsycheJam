using UnityEngine;
using System.Collections;

public class SharedMonsterBehavior : MonoBehaviour {
    
    //idk
    private float tooLow = -10;

	// Use this for initialization
	void Start () 
    {
        SpawnMonster.currentMonsters++;
	}
	
	// Update is called once per frame
	void Update () 
    {
        checkForOffscreenDeath();
	}

    void checkForOffscreenDeath()
    {
        if (transform.position.y < tooLow)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
        SpawnMonster.currentMonsters--;
    }

    
}
