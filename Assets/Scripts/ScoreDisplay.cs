using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {
	public Material zero;
	public Material one;
	public Material two;
	public Material three;
	public Material four;
	public Material five;
	public Material six;
	public Material seven;
	public Material eight;
	public Material nine;
	public Material blank;
	private Material[] nums;

	public GameObject homeSingles;
	public GameObject homeTens;
	public GameObject homeHundreds;
	private MeshRenderer[] home;
	public GameObject guestSingles;
	public GameObject guestTens;
	public GameObject guestHundreds;
	private MeshRenderer[] guest;
	public GameObject minutesSingles;
	public GameObject minutesTens;
	public GameObject secondsSingles;
	public GameObject secondsTens;
	private MeshRenderer[] time;
	public GameObject healthSingles;
	public GameObject healthTens;
	public GameObject healthHundreds;
	private MeshRenderer[] health;

	[HideInInspector] public int homeScore;
	private int guestScore;
	private float startTime;
	private float timeElapsed;
	private string levelName;


	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
		startTime = Time.time;
		nums = new Material[11]{zero, one, two, three, four, five, six, seven,
			eight, nine, blank};
		home = new MeshRenderer[3]{homeSingles.GetComponent<MeshRenderer>(),homeTens.GetComponent<MeshRenderer>(),homeHundreds.GetComponent<MeshRenderer>()};
		guest = new MeshRenderer[3]{guestSingles.GetComponent<MeshRenderer>(),guestTens.GetComponent<MeshRenderer>(),guestHundreds.GetComponent<MeshRenderer>()};
		time = new MeshRenderer[4]{secondsSingles.GetComponent<MeshRenderer>(),secondsTens.GetComponent<MeshRenderer>(),minutesSingles.GetComponent<MeshRenderer>(),minutesTens.GetComponent<MeshRenderer>()};
		health = new MeshRenderer[3]{healthSingles.GetComponent<MeshRenderer>(),healthTens.GetComponent<MeshRenderer>(),healthHundreds.GetComponent<MeshRenderer>()};
	}

	// Use this for initialization
	void Start () {
		ResetNumbers (home);
		ResetNumbers (guest);
		ResetNumbers (time);
		ResetNumbers (health);
	}

	void ResetNumbers(MeshRenderer[] meshes)
	{
		foreach (MeshRenderer mr in meshes)
			mr.material = zero;
	}

	// Update is called once per frame
	void Update () {
		levelName = Application.loadedLevelName;
		if (levelName != "GameOver2") {
			timeElapsed = Time.time - startTime;
			DisplayTime ((int)timeElapsed);
		}
		DisplayHomeScore (homeScore);
		DisplayGuestScore (guestScore);
		DisplayHealth (GameObject.Find ("Player").GetComponent<PlayerHealth> ().currentHealth);
	}

	void OnLevelWasLoaded(int level)
	{
		if (level == 0) {
			ResetNumbers (home);
			ResetNumbers (guest);
			ResetNumbers (time);
		} else if (level == 2) {
			ResetNumbers (home);
			ResetNumbers (time);
			startTime = Time.time;
		} else if (level == 1) {
			++guestScore;
		}
	}

	void DisplayTime(int timeInSeconds)
	{
		time[0].material = nums[timeInSeconds % 10];
		timeInSeconds /= 10;
		time[1].material = nums [timeInSeconds % 6];
		timeInSeconds /= 6;
		time [2].material = nums [timeInSeconds % 10];
		timeInSeconds /= 10;
		time [3].material = nums [timeInSeconds % 10];
	}

	void DisplayHomeScore(int hScore)
	{
		home [0].material = nums [hScore % 10];
		hScore /= 10;
		home [1].material = nums [hScore % 10];
		hScore /= 10;
		home [2].material = nums [hScore % 10];
	}
	void DisplayGuestScore(int gScore)
	{
		guest [0].material = nums [gScore % 10];
		gScore /= 10;
		guest [1].material = nums [gScore % 10];
		gScore /= 10;
		guest [2].material = nums [gScore % 10];
	}
	void DisplayHealth(int gScore)
	{
		health [0].material = nums [gScore % 10];
		gScore /= 10;
		health [1].material = nums [gScore % 10];
		gScore /= 10;
		health [2].material = nums [gScore % 10];
	}
}
