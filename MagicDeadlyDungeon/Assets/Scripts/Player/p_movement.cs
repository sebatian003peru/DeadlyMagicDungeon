using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class p_movement : MonoBehaviour {

    public float speed = 10f;
    public int hp;
    private Vector3 targetPosition;
    private bool isMoving;



    // Use this for initialization
    void Start()
    {
        targetPosition = transform.position;
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
            Destroy(this.gameObject);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 30f))
        {
            
            Debug.DrawLine(ray.origin, hitInfo.point, Color.green, 0.01f);
            if (Input.GetMouseButton(0))
                SetTargetPosition();
            if (isMoving)
                MovePlayer();
            
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.direction * 30f, Color.red, 0.01f);
        }

      

    }

    void SetTargetPosition()
    {
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if (plane.Raycast(ray, out point))
            targetPosition = ray.GetPoint(point);

        isMoving = true;
    }

    void MovePlayer()
    {
        transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition)
            isMoving = false;

        Debug.DrawLine(transform.position, targetPosition, Color.red);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "danger")
        {
           hp--;
        }
    }
}

