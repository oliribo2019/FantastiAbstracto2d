using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoScr : MonoBehaviour {
/*
    public GameObject back;
    public GameObject middle;
    public GameObject near;

    public AudioSource music;

    public PlayerScr player;

    private float originalBackScrollY;
    private float originalMiddleScrollY;
    private float originalNearScrollY;

    private float scrollSpeed;
    private float playerYposition;

    private void Start() {
        originalBackScrollY = back.transform.position.y;
        originalMiddleScrollY = middle.transform.position.y;
        originalNearScrollY = near.transform.position.y;
    }

    // Update is called once per frame
    private void FixedUpdate () {
        HorizontalScroll();
        VerticalScroll();
	}

    private void HorizontalScroll() {
        scrollSpeed += player.velocidad;
        back.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(scrollSpeed * 0.5f, 0));
        middle.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(scrollSpeed * 0.25f, 0));
        near.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(scrollSpeed, 0));
    }

    private void VerticalScroll() {
        playerYposition = player.transform.position.y;
        float playerMargins = Mathf.Clamp(playerYposition ,- 0.4f, 1.9f);
        back.transform.position = new Vector3(back.transform.position.x, playerMargins * originalBackScrollY * -2.5f, back.transform.position.z);
        middle.transform.position = new Vector3(middle.transform.position.x, playerMargins * originalMiddleScrollY * 0.25f, middle.transform.position.z);
        near.transform.position = new Vector3(near.transform.position.x, playerMargins * originalNearScrollY, near.transform.position.z);
    }*/
}
