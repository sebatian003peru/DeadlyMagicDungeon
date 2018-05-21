using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : MonoBehaviour {

    public Transform Player;
    public float attackTime;
    public float elapsedAttack;

   // Vector3 lookPos;




    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       // lookPos = Player.position - transform.position;
        //lookPos.y = 0;


    }
        
        void Update ()
    {
        
        //Quaternion rotation = Quaternion.LookRotation(lookPos);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);


        if (elapsedAttack >= attackTime)
            Player.GetComponent<p_movement>().hp = -1;


			
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            elapsedAttack += Time.deltaTime;
		    transform.LookAt(Player);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            elapsedAttack = 0;
		
    }


}
