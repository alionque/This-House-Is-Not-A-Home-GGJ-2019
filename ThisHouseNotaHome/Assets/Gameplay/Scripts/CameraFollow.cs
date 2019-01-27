using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float cameraSpeed = 2f;

    // Start is called before the first frame update
    void Start() {
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = player.position.x;
        cameraPosition.y = player.position.y;
        transform.position = cameraPosition;
    }

    // Update is called once per frame
    void Update() {
        FollowPlayer();
    }

    private void FollowPlayer() {
        float interpolation = Time.deltaTime * cameraSpeed;
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = Mathf.Lerp(transform.position.x, player.position.x, interpolation);
        cameraPosition.y = Mathf.Lerp(transform.position.y, player.position.y, interpolation);
        transform.position = cameraPosition;
    }
}
