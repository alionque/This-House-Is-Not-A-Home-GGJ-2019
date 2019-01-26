using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public float timer = 120f;

    public static GameController instance;

    // Start is called before the first frame update
    void Start() {
        if(instance != null && instance != this) {
            Destroy(this.gameObject);
        }
        GameController.instance = this;
    }

    // Update is called once per frame
    void Update() {
        timer -= Time.deltaTime;
        if (timer <= 0f) {
            //TODO: Gameover
        } else {
            //TODO: Display time
        }

    }
}

