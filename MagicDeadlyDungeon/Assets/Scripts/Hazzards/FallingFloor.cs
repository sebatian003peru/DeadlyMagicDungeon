using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloor : MonoBehaviour {

    public float breakingtime;
    public float decayTime;
    [SerializeField]

	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (decayTime >= breakingtime)
            Destroy(this.gameObject);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            decayTime += Time.deltaTime;
    }

}
