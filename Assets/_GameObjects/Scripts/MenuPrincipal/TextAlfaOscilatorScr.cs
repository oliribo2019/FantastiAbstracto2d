using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAlfaOscilatorScr : MonoBehaviour {

    private bool decrease = true;
    private float alpha = 1f;
    private Color originalColor;

    private void Start() {
        originalColor = this.GetComponent<Text>().color;
    }

    // Update is called once per frame
    //Efecto guapo de alpha distinto si es de bajada o subida
    private void FixedUpdate () {
        if (decrease) {
            alpha -= 0.05f;
            if (alpha <= 0f) {
                decrease = false;
            }
        } else {
            alpha += 0.01f;
            if (alpha >= 1f) {
                decrease = true;
            }
        }
        originalColor.a = alpha;
        this.GetComponent<Text>().color = originalColor;
    }
}
