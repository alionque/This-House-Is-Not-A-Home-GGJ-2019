using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTracker : MonoBehaviour {
    public static ItemTracker instance;

    private ArrayList foundItems = new ArrayList();

    // Start is called before the first frame update
    void Start() {
        if (instance != null) {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
    }

    public void FoundItem(int itemId) {
        foundItems.Add(itemId);
    }

    public ArrayList GetFoundItems() {
        return foundItems;
    }
}
