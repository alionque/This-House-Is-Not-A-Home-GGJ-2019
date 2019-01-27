using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {
    [SerializeField]
    private string interactionInput;
    [SerializeField]
    private PlayerMovement playerMovementComponent;
    [SerializeField]
    private float interactionDistance;
	[SerializeField]
	private AudioSource audioSource;
	public AudioClip bush;


    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {
      /*  if (Input.GetButtonDown(interactionInput)) {
            interact();
        }*/
    }


	void OnCollisionEnter2D(Collision2D other){
		Collectible collectible = other.gameObject.GetComponent<Collectible>();
		if (collectible != null) {
			ItemTracker.instance.FoundItem (collectible);
		}

		if (other.gameObject.tag == "Bush")
			audioSource.PlayOneShot (bush);

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
