using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public static GameController instance;

    [SerializeField]
    private string gameOverSceneName;
    [SerializeField]
    private Text timerText;

    public float timer = 120f;

    // Start is called before the first frame update
    void Start() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        }
        GameController.instance = this;
    }

    // Update is called once per frame
    void Update() {
        timer -= Time.deltaTime;
        if (timer <= 0f) {
            SceneManager.LoadScene(gameOverSceneName);
        } else {
            UpdateTimerUI();
        }
    }

    private void UpdateTimerUI() {
        int min = (int)(timer / 60f);
        int seconds = (int)(timer % 60f);
        string time = "";
        if (min > 0) {
            time += min + ":";
        }
        if (seconds < 10) {
            time += "0";
        }
        time += seconds;

        timerText.text = time;
    }
}

