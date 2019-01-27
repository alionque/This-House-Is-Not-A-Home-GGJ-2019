using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Results : MonoBehaviour {
    [SerializeField]
    private GameObject[] itemImages;
    // Start is called before the first frame update
    void Start() {
        if(ItemTracker.instance == null) {
            return;
        }

        int[] collectedItemIds = ItemTracker.instance.GetFoundItems().ToArray();

        foreach(int i in collectedItemIds) {
            itemImages[i - 1].SetActive(true);
        }

        Destroy(ItemTracker.instance.gameObject);
        Destroy(this.gameObject);
    }
}
