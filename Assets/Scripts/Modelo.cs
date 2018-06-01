using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modelo : MonoBehaviour {

	public float Vida;
	public float Cura;
	public bool curando;
	
	public static Modelo instance;
	void Start()
	{
		instance=this;
		Vida =100;
		Cura =100;
		curando =false;
		Debug.Log ("Si esta curando vida aumenta en cura");
	}
}
