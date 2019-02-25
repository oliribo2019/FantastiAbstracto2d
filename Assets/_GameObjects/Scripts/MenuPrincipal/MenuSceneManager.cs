using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour {

    public AudioSource startSoundEffect;
    public AudioSource music;
    public RectTransform panelTransform;
    public Text record1;
    public Text record2;
    public Text record3;
    private bool push = false;
    private float magicNumber = 1f;

    private void Start() {
        record1.text = "Record 1: " + PlayerPrefs.GetInt(GameManager.RECORD1);
        record2.text = "Record 2: " + PlayerPrefs.GetInt(GameManager.RECORD2);
        record3.text = "Record 3: " + PlayerPrefs.GetInt(GameManager.RECORD3);
    }

    // Update is called once per frame
    private void FixedUpdate () {
        this.transform.Rotate(Vector3.up);
        this.transform.Rotate(Vector3.right);

        if (Input.anyKeyDown && !push) {
            push = true;
            startSoundEffect.Play();
            
        }

        if (push) {
            Vector3 temp = panelTransform.localScale;
            magicNumber -= 0.006f;
            if (magicNumber <= 0f) {
                magicNumber = 0f;
            }
            music.volume -= magicNumber;
            temp.y = magicNumber;
            panelTransform.localScale = temp;
            StartCoroutine(NextScene());
        }
    }

    private IEnumerator NextScene() {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Stage1Scn");
        
    }
}
