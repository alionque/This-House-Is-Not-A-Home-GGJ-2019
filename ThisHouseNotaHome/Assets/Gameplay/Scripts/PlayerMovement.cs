using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private readonly float maxVel;
    [SerializeField]
    private readonly string horizontalInput, verticalInput;

    private readonly Rigidbody2D rb;
    private Vector2 dir = new Vector2();

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() {
        Move();
    }

    private void Move() {
        dir.x = Input.GetAxis(horizontalInput);
        dir.y = Input.GetAxis(verticalInput);
        rb.velocity = dir * maxVel;
    }
}

