using UnityEngine;
using System.Collections;

public class SharedMonsterBehavior : MonoBehaviour {
   
    private float minimumY = -20;

    private float minimumX = -100;
    private float minimumZ = -100;
    private float maximumX = 100;
    private float maximumZ = 100;

	private ScoreDisplay score;

    public GameObject explosionParticles;
	// Use this for initialization
	void Start () 
    {
        SpawnMonster.currentMonsters++;
		score = GameObject.Find ("Scoreboard").GetComponent<ScoreDisplay> ();
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
            return;
        }
        if (transform.position.x > maximumX || transform.position.x < minimumX ||
            transform.position.z > maximumZ || transform.position.z < minimumZ)
		{
			score.homeScore++;
            Instantiate(explosionParticles, transform.position, Quaternion.identity);
            Die();
            return;
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
        SpawnMonster.currentMonsters--;
    }
   
}
