using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour {

    public static controlador instance;
    

	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void posion(bool curacion)
    {
        curacion = false;
        if (curacion == true)
        {
            Modelo.instance.Vida += Modelo.instance.Cura;
            Debug.Log("curan");
        }
    }
}
