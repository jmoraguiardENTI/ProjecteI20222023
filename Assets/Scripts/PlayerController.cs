using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float unitsMovementSpeed = 0.001f;
    Rigidbody2D rg2d = null;
    float movementDirection = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        //rg2d.MovePosition(rg2d.position + movementDirection * new Vector2(unitsMovementSpeed, 0) * Time.fixedDeltaTime);
        rg2d.velocity = new Vector2(movementDirection * unitsMovementSpeed * Time.fixedDeltaTime, rg2d.velocity.y);
    }
}
