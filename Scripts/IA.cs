using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour // NO IMPLEMENTADO
{
    [SerializeField] public GameObject ball;
    [SerializeField] private Vector2 ballPos;
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        ballPos = ball.transform.position;
        if (transform.position.y > ballPos.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime);
        }
        if (transform.position.y < ballPos.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
    }
}
