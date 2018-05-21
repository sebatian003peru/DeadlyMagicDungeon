using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTrap : MonoBehaviour {

	public float breakingtime=1;
	public float decayTime;
	public Transform spawn;
	public GameObject rock;
	[SerializeField]

	void Start () {

	}

	// Update is called once per frame
	void Update()
	{
		if (decayTime >= breakingtime)
		{
			Destroy (this.gameObject);
			Instantiate (rock, spawn.position, spawn.rotation);
		}
			

		   
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
			decayTime += Time.deltaTime;
	}

}

