using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {
public float FallDelay = 0.1f;

	void Start () {
		
	}
	
	void Update () {
		
	}
	void OnTriggerExit(Collider trigger)
	{
		if (trigger.tag=="Player")
		{
			TileManager.Instance.SpawnTile();
			StartCoroutine(FallDown());
		}
	}
	private IEnumerator FallDown()
	{
		yield return new WaitForSeconds(FallDelay);
		GetComponent<Rigidbody>().isKinematic=false;
	}
}
