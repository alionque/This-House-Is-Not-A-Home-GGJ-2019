using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private float maxVel, inputDeadZone = .3f;
    [SerializeField]
    private string horizontalInput, verticalInput;
    [SerializeField]
    private Rigidbody2D rb;

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
        if (Mathf.Abs(dir.x) > inputDeadZone || Mathf.Abs(dir.y) > inputDeadZone) {
            rb.velocity = dir * maxVel;

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle + 90f, Vector3.forward);

			GetComponent<Animator> ().SetBool ("Moving", true);
        } else {
            rb.velocity = Vector2.zero;
			GetComponent<Animator> ().SetBool ("Moving", false);
        }
    }

    public Vector2 GetDirection() {
        return dir;
    }
}

