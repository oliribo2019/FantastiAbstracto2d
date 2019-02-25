﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaReboteScr : MonoBehaviour {

    private bool empiezoAcaer = false   ;
    private Color actualColor;
    private float fullColor = 1f;


    private void OnCollisionEnter2D(Collision2D collision) {

       if (!empiezoAcaer) {
            empiezoAcaer = true;
            actualColor = this.GetComponent<SpriteRenderer>().color;
            StartCoroutine(Time());
        }

    }

    private void Update() {
        if (empiezoAcaer) {
            this.GetComponent<PlatformColorScr>().enabled = false;
            fullColor -= 0.01f;
            this.GetComponent<SpriteRenderer>().color = new Color(fullColor, fullColor, fullColor);
        }
    }

    private IEnumerator Time() {
        yield return new WaitForSeconds(1);
        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
        this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
