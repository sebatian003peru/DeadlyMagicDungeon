using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendolum : MonoBehaviour {

	public float speed = 200f;
	public float jumpDistance = 2f;
	public float angle;
	public float r = 4f;
	public Vector3 center;
    public Transform reference;

	float j;

    bool oscilation = true;

    void Start () {
        center = reference.position;
	}
	
	void Update () {

        if (oscilation)
            angle -= speed * Time.deltaTime;
        else
            angle += speed * Time.deltaTime;

        if (angle < -180)
            oscilation = false;

        if (angle > 0)
            oscilation = true;

		angle = Mathf.Clamp(angle, -360f, 360f);


	}

	void LateUpdate(){
		float rad = angle*Mathf.Deg2Rad;
		float x = Mathf.Cos(rad);
		float y = Mathf.Sin(rad);
		
		Vector3 pos = new Vector3(x, y, 0f);

		transform.position = center + (pos * (r + j));
		transform.up = transform.position - center;
	}


}
