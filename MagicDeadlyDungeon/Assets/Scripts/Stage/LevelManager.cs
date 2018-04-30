using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public enum TileType {
		typeA, typeB, typeC
	}
	
	public GameObject[] tiles;
	public TileType[] pattern;

	// Use this for initialization
	void Start () {
		Vector3 starPosition = transform.position;
		Vector3 position = starPosition;

		Quaternion rotation = transform.rotation;

		foreach(int p in pattern){	
			GameObject tile = tiles[p];
			GameObject clone = Instantiate(tile, position, rotation);
			
			position = clone.transform.Find("exit").position;
			rotation = clone.transform.Find("exit").rotation;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
