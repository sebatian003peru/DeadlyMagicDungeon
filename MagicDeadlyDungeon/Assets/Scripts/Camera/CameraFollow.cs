using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour {

    public GameObject player;       


    private Vector3 offset;


    void Start()
    {
       
        offset = transform.position - player.transform.position;
    }

    private void Update()
    {
        if (player == null)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    void LateUpdate()
    {
        
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Euler(45, 30, 0);
    }
}



