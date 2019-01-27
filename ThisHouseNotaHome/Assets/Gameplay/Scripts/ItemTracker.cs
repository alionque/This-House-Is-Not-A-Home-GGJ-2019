using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTracker : MonoBehaviour {
    public static ItemTracker instance;

    [SerializeField]
    private AudioSource audioSource;

    private List<int> foundItems = new List<int>();

    // Start is called before the first frame update
    void Start() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void FoundItem(Collectible collectible) {
        foundItems.Add(collectible.itemId);
        audioSource.PlayOneShot(collectible.collectionSound);
        Destroy(collectible.gameObject);
    }

    public List<int> GetFoundItems() {
        return foundItems;
    }
}
