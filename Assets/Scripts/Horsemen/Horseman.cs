﻿using UnityEngine;

public class Horseman : MonoBehaviour
{
	[SerializeField]
	private HorsemanData HorsemanData;
	Life life;
	Vector3 pos;  
	private void Start()
	{
		life = new Life();
		life.HealthPoints = HorsemanData.MaxHealthPoint;
		pos = transform.position;
	}
	Vector3 move;
	private void Update()
	{
		if (Input.GetKey(KeyCode.Q)){
			pos.x += -HorsemanData.SpeedRiding *Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D)) {
			pos.x += HorsemanData.SpeedRiding * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Z)) {
			pos.z += HorsemanData.SpeedRiding * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S)) {
			pos.z += -HorsemanData.SpeedRiding * Time.deltaTime;
		}
		transform.position = pos;
	}
}