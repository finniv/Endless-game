using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
public float Speed;

private Vector3 dir;
	void Start () 
	{
		dir = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			if (dir==Vector3.forward)
			{
				dir = Vector3.left;
			}
			else
			{
				dir=Vector3.forward;
			}
		}
		float amoutToMoove = Speed * Time.deltaTime;
		transform.Translate(dir * amoutToMoove);
	}
}
