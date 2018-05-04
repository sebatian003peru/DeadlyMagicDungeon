using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform Player;
    public float MoveSpeed = 1f;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    void Update()
    {
        transform.LookAt(Player);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;


        
    }
}
