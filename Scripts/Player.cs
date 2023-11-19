using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool isPlayer1;
    float movement;
    private float yBound = 3.65f;


    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2"); // Este "Vertical2" ha sido creado de manera manual en Project Settings --> Input Manager --> Axes (Sus movimientos son Negative Button: s y Positive Button: w)
        }
        Vector2 playerPosition = transform.position;
        playerPosition.y = Mathf.Clamp(playerPosition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = playerPosition;
    }
}
