using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColorScr : MonoBehaviour {

    public string color;
    private Color actualColor;
    private float fullColor = 1f;
    private bool increase = false;

    private void Start() {
        actualColor = this.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update () {

        if (fullColor >= 1f && increase) {
            increase = false;
        } else if (fullColor <= 0f && !increase) {
            increase = true;
        }

        if (increase) {
            fullColor += 0.01f;
        } else {
            fullColor -= 0.01f;
        }
        
        if (color == "R") {
            this.GetComponent<SpriteRenderer>().color = new Color(actualColor.r, fullColor, fullColor);
        }
        if (color == "G") {
            this.GetComponent<SpriteRenderer>().color = new Color(fullColor, actualColor.g, fullColor);
        }
        if (color == "B") {
            this.GetComponent<SpriteRenderer>().color = new Color(fullColor, fullColor, actualColor.b);
        }

		
	}
}
