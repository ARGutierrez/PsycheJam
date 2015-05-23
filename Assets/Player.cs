using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{

	private GameObject m_currentTarget;
	public GameObject Target
	{
		get { return m_currentTarget; }
		set 
		{
			m_currentTarget = value;
		}
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
