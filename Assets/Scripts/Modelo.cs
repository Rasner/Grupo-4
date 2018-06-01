using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modelo : MonoBehaviour {

	public float Vida;
	public float Cura;
	public bool curando;
	
	
	void Start()
	{
		Vida =100;
		Cura =100;
		curando =false;
	}
}
