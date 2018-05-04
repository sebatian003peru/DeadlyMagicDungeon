using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public enum TileType {
		typeA, typeB, typeC
	}

	public int minTile =0;
	public int maxTile =1;
	public GameObject[] tiles;
	public TileType[] pattern;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P))
		{
			GenerateStage ();
		}
	}

	void OnTrigger(Collider col)
	{
		if (col.gameObject.tag == "end") 
		{
			GenerateStage ();
			Destroy (this.gameObject);
		}

	
	}

	public void GenerateStage()
	{
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

	public void ChoosePiece()

	{
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
            GenerateStage();
    }


}

