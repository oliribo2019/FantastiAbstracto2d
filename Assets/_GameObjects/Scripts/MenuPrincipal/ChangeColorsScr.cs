using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorsScr : MonoBehaviour {

    private void Start() {
        StartCoroutine(time());
    }

    //Cambiamos el color del texto y las sombras aleatoriamente
    private IEnumerator time() {
        while (true) {
            yield return new WaitForSeconds(2);
            this.GetComponent<Text>().color = RandomColor();
            this.GetComponent<Shadow>().effectColor = RandomColor();
        }

    }

    private Color RandomColor() {
        float randomR = Random.Range(0, 10) * 0.1f;
        float randomG = Random.Range(0, 10) * 0.1f;
        float randomB = Random.Range(0, 10) * 0.1f;
        return new Color(randomR, randomG, randomB);
    }
}
