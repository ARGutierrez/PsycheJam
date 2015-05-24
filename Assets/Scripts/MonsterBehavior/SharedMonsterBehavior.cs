using UnityEngine;
using System.Collections;

public class SharedMonsterBehavior : MonoBehaviour {
   
    private float minimumY = -20;

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
        if (transform.position.y < minimumY)
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
