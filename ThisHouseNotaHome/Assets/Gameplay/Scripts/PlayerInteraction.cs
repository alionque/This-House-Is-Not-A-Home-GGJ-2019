using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {
    [SerializeField]
    private readonly string interactionInput;
    [SerializeField]
    private readonly PlayerMovement playerMovementComponent;
    [SerializeField]
    private readonly float interactionDistance;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown(interactionInput)) {

        }
    }

    private void interact() {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerMovementComponent.GetDirection().normalized, interactionDistance);

        if (hit.collider != null) {
            Collectible collectible = hit.collider.gameObject.GetComponent<Collectible>();
            if (collectible != null) {
                ItemTracker.instance.FoundItem(collectible);
            }
        }
    }
}
