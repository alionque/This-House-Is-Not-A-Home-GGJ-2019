using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private readonly float maxVel, inputDeadZone = .3f;
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
        if (Mathf.Abs(dir.x) > .3f || Mathf.Abs(dir.y) > .3f) {
            dir.x = Input.GetAxis(horizontalInput);
            dir.y = Input.GetAxis(verticalInput);
            rb.velocity = dir * maxVel;

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle + 90f, Vector3.forward);
        } else {
            rb.velocity = Vector2.zero;
        }
    }

    public Vector2 GetDirection() {
        return dir;
    }
}

