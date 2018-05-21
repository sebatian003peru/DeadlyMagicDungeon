using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    //public enum TileType {
    //typeA, typeB, typeC
    //}

    //public int minTile =0;
    //public int maxTile =1;
    //public GameObject[] tiles;
    //public TileType[] pattern;

    bool selfDestruct = false;
    public GameObject[] roomAvalaible;
    public GameObject testing;
    int roomIndex;
    Transform roomSpawn;
    public int totalRoomsSpawned = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GenerateStage();
        }

        if (totalRoomsSpawned >= 2)
        {
            Destroy(this.gameObject);
        }
    }


        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == "Player")
            {
                GenerateStage();

            }

        }
    


	public void GenerateStage()
	{
        roomSpawn = GameObject.FindGameObjectWithTag("spawner").GetComponent<Transform>();
        roomIndex = Random.Range(0,(roomAvalaible.Length)+1);
		Vector3 starPosition = roomSpawn.transform.position;
		Vector3 position = starPosition;
		Quaternion rotation = transform.rotation;
        GameObject clone = Instantiate(roomAvalaible[roomIndex], position, rotation);
        position = clone.transform.Find("exit").position;
        rotation = clone.transform.Find("exit").rotation;
        totalRoomsSpawned += 1;
        //foreach(int p in pattern){	

        //GameObject tile = tiles[p];
        //GameObject clone = Instantiate(tile, position, rotation);


        //selfDestruct = true;


    }


	}






