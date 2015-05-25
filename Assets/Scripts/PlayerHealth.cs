using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public bool invincible = false; //for debugging or fun

    public int maxHealth = 100;
    public int currentHealth;

    private float minimumY = -100f;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < minimumY)
            gameOver();
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (!invincible)
            {
                takeDamage(5);
          
            }
            Destroy(collision.gameObject);
        }
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
            gameOver();
    }

    public void gameOver()
    {
		string level = Application.loadedLevelName;
        if (level == "GameOver2") 
            Application.LoadLevel("Level1");
        else if (level == "Level0" || level == "Level1") 
            Application.LoadLevel("GameOver2");
        else
            Debug.Log("???" + Application.loadedLevelName);
    }
}
