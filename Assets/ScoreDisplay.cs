﻿using UnityEngine;
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

	private int homeScore;
	private int guestScore;
	private int timeInSeconds;
	private float startTime;
	private float timeElapsed;

	void Awake(){
		startTime = Time.time;
		nums = new Material[11]{zero, one, two, three, four, five, six, seven,
			eight, nine, blank};
		home = new MeshRenderer[3]{homeSingles.GetComponent<MeshRenderer>(),homeTens.GetComponent<MeshRenderer>(),homeHundreds.GetComponent<MeshRenderer>()};
		guest = new MeshRenderer[3]{guestSingles.GetComponent<MeshRenderer>(),guestTens.GetComponent<MeshRenderer>(),guestHundreds.GetComponent<MeshRenderer>()};
		time = new MeshRenderer[4]{secondsSingles.GetComponent<MeshRenderer>(),secondsTens.GetComponent<MeshRenderer>(),minutesSingles.GetComponent<MeshRenderer>(),minutesTens.GetComponent<MeshRenderer>()};
	}

	// Use this for initialization
	void Start () {
		foreach (MeshRenderer mr in home) {
			mr.material = zero;
		}
		foreach (MeshRenderer mr in guest) {
			mr.material = zero;
		}
		foreach (MeshRenderer mr in time) {
			mr.material = zero;
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed = Time.time - startTime;
		timeInSeconds = (int)timeElapsed;
		time[0].material = nums[timeInSeconds % 10];
		timeInSeconds /= 10;
		time[1].material = nums [timeInSeconds % 6];
		timeInSeconds /= 6;
		time [2].material = nums [timeInSeconds % 10];
		timeInSeconds /= 10;
		time [3].material = nums [timeInSeconds % 10];
	}
}
