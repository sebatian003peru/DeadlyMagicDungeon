using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour {

	public Texture2D map;
	public Color green;
	public Color blue;

	public GameObject greenSprite;
	public GameObject blueSprite;

	// Use this for initialization
	void Start () {
		for(int x=0; x < map.width; x++) {
			for(int y=0; y < map.height; y++) {
				Color color = map.GetPixel(x,y);
				if (color == green)
					Instantiate(greenSprite, new Vector3(x, y, 0), Quaternion.identity);
				else if (color == blue)
					Instantiate(blueSprite, new Vector3(x, y, 0), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
