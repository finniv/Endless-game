using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour 
{
	public GameObject CurrentTile;
	public GameObject [] TilesArray;

	private static TileManager instance;

	private Stack<GameObject> leftTiles = new Stack<GameObject>();
    public static TileManager Instance
    {
        get
        {
			if (instance==null)
			{
				Debug.Log("initialize of instance called");
				instance = GameObject.FindObjectOfType<TileManager>();
			}
            return instance;
        }
    }

    void Start () 
	{
		for (int i = 0; i < 10; i++)
		{
			SpawnTile();
		}
	}
	
	void Update () 
	{
		
	}
	public void SpawnTile()
	{
		int randomIndexTile = Random.Range(0,2);
		int randomIndexChild = Random.Range(0,2);
		CurrentTile = Instantiate(TilesArray[randomIndexTile],CurrentTile.transform.GetChild(0).transform.GetChild(randomIndexChild).position,Quaternion.identity);
	}
	
}
