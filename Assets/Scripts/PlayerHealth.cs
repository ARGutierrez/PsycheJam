using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
    public int maxHealth = 100;
    public int currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            takeDamage(5);
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
        Application.LoadLevel("GameOver");
    }
}
