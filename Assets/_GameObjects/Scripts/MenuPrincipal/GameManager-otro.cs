using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerotro : MonoBehaviour {
    /*
    private bool gameStarted = false;

    public GameObject player;

    public int puntos;
    public bool cuentaPuntos = false;

    public GameObject coin;

    private int nVidas = 3;

    public Text puntosTxt;
    public Text vidasTxt;

    public AudioSource muerteSound;
    public AudioSource musica;

    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;

    public GameObject platPeq;
    public GameObject platMed;
    public GameObject platGra;
    public GameObject platReb;
    public GameObject platCae;

    public GameObject plataformaSpawn;
    private Vector3 plataformaSpawnOriginalPos;
    private Quaternion plataformaSpawnOriginalRot;
    private Vector3 playerOriginalPos;
    private Quaternion playerOriginalRot;

    public static readonly string RECORD1 = "record1";
    public static readonly string RECORD2 = "record2";
    public static readonly string RECORD3 = "record3";
    public static readonly string LAST_RECORD = "lastRecord";

    private int alturaActual = 3;
    private bool creandoPlatforma = false;
    private int lastTipo = 3;

    private bool tiempoMuerte;

    private void Start() {
        plataformaSpawnOriginalPos = plataformaSpawn.transform.position;
        plataformaSpawnOriginalRot = plataformaSpawn.transform.rotation;
        playerOriginalPos = player.transform.position;
        playerOriginalRot = player.transform.rotation;

        
    }

    public void Morir() {
        tiempoMuerte = true;
        nVidas--;
        vidasTxt.text = nVidas.ToString();
        gameStarted = false;
        cuentaPuntos = false;
        creandoPlatforma = true;
        StartCoroutine(Time2Death());
        player.GetComponent<PlayerScr>().enabled = false;
        if (nVidas == 0) {
            StopAllCoroutines();
            if (PlayerPrefs.GetInt(GameManager.RECORD1) < puntos) {
                PlayerPrefs.SetInt(GameManager.RECORD1, puntos);
            } else if (PlayerPrefs.GetInt(GameManager.RECORD2) < puntos) {
                PlayerPrefs.SetInt(GameManager.RECORD2, puntos);
            } else if (PlayerPrefs.GetInt(GameManager.RECORD3) < puntos) {
                PlayerPrefs.SetInt(GameManager.RECORD3, puntos);
            }
            PlayerPrefs.SetInt(GameManager.LAST_RECORD, puntos);
            StartCoroutine(GameOver());
        } 
    }

    private IEnumerator GameOver() {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameOver");
    }

    private IEnumerator Time2Death() {
        yield return new WaitForSeconds(3);
        player.GetComponent<PlayerScr>().myAnimator.SetBool("GameStart", false);
        player.GetComponent<PlayerScr>().myAnimator.SetBool("PlayerMuerto", false);
        player.GetComponent<Rigidbody2D>().Sleep();
        player.transform.position = playerOriginalPos;
        player.transform.rotation = playerOriginalRot;
        player.GetComponent<Rigidbody2D>().WakeUp();
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        Instantiate(plataformaSpawn, plataformaSpawnOriginalPos, plataformaSpawnOriginalRot);
        tiempoMuerte = false;
    }


    private void RandomPlatformGenerator() {
        if (Random.Range(10, 20) >= 10 && alturaActual < 6) { //NOS MOVEMOS HACIA ARRIBA
            if(Random.Range(10, 20) >= 10 && lastTipo != 3) {
                alturaActual++;
            }
        } else { // ABAJO
            alturaActual = Random.Range(1, alturaActual);
        }

        switch (alturaActual) {
            case 1: Instantiate(RandomTipoPlataforma(), spawn1.transform.position, spawn1.transform.rotation); break;
            case 2: Instantiate(RandomTipoPlataforma(), spawn2.transform.position, spawn2.transform.rotation); break;
            case 3: Instantiate(RandomTipoPlataforma(), spawn3.transform.position, spawn3.transform.rotation); break;
            case 4: Instantiate(RandomTipoPlataforma(), spawn4.transform.position, spawn4.transform.rotation); break;
            case 5: Instantiate(RandomTipoPlataforma(), spawn5.transform.position, spawn5.transform.rotation); break;
            case 6: Instantiate(RandomTipoPlataforma(), spawn6.transform.position, spawn6.transform.rotation); break;
            default: break;
        }

        RandomCoin();
    }

    private void RandomCoin() {
        if (Random.Range(1, 20) > 10) {
            switch (alturaActual) {
                case 1: Instantiate(coin, new Vector3(spawn2.transform.position.x + Random.Range(1.0f, 3.5f), spawn2.transform.position.y, spawn2.transform.position.z), spawn2.transform.rotation); break;
                case 2: Instantiate(coin, new Vector3(spawn3.transform.position.x + Random.Range(1.0f, 3.5f), spawn3.transform.position.y, spawn3.transform.position.z), spawn3.transform.rotation); break;
                case 3: Instantiate(coin, new Vector3(spawn4.transform.position.x + Random.Range(1.0f, 3.5f), spawn4.transform.position.y, spawn4.transform.position.z), spawn4.transform.rotation); break;
                case 4: Instantiate(coin, new Vector3(spawn5.transform.position.x + Random.Range(1.0f, 3.5f), spawn5.transform.position.y, spawn5.transform.position.z), spawn5.transform.rotation); break;
                case 5: Instantiate(coin, new Vector3(spawn6.transform.position.x + Random.Range(1.0f, 3.5f), spawn6.transform.position.y, spawn6.transform.position.z), spawn6.transform.rotation); break;
                default: break;                                                                       
            }                                                                                         
        } else if(Random.Range(1, 20) > 10) {                                                         
            switch (alturaActual) {                                                                   
                case 1: Instantiate(coin, new Vector3(spawn2.transform.position.x - Random.Range(1.0f, 3.5f), spawn2.transform.position.y, spawn2.transform.position.z), spawn2.transform.rotation); break;
                case 2: Instantiate(coin, new Vector3(spawn3.transform.position.x - Random.Range(1.0f, 3.5f), spawn3.transform.position.y, spawn3.transform.position.z), spawn3.transform.rotation); break;
                case 3: Instantiate(coin, new Vector3(spawn4.transform.position.x - Random.Range(1.0f, 3.5f), spawn4.transform.position.y, spawn4.transform.position.z), spawn4.transform.rotation); break;
                case 4: Instantiate(coin, new Vector3(spawn5.transform.position.x - Random.Range(1.0f, 3.5f), spawn5.transform.position.y, spawn5.transform.position.z), spawn5.transform.rotation); break;
                case 5: Instantiate(coin, new Vector3(spawn6.transform.position.x - Random.Range(1.0f, 3.5f), spawn6.transform.position.y, spawn6.transform.position.z), spawn6.transform.rotation); break;
                default: break;
            }
        }
    }

    private IEnumerator Time() {
        yield return new WaitForSeconds(1.5f - (player.GetComponent<PlayerScr>().velocidad * 80f));
        RandomPlatformGenerator();
        creandoPlatforma = false;
    }

    private GameObject RandomTipoPlataforma() {
        GameObject plataforma = null;
        if (lastTipo != 3) {
            plataforma = platGra;
            lastTipo = 3;
        } else {
            lastTipo = Random.Range(1, 6);
            switch (lastTipo) {
                case 1: plataforma = platPeq; break;
                case 2: plataforma = platMed; break;
                case 3: plataforma = platGra; break;
                case 4: plataforma = platReb; break;
                case 5: plataforma = platCae; break;
                default: break;
            }
        }
        return plataforma;
    }

    public void Update() {
        if (Input.anyKeyDown && !gameStarted && !tiempoMuerte) {
            gameStarted = true;
            player.GetComponent<PlayerScr>().enabled = true;
            player.GetComponent<PlayerScr>().Empezar();
            Instantiate(platGra, spawn3.transform.position, spawn3.transform.rotation);
            if (!musica.isPlaying) {
                musica.pitch = 1f;
                musica.Play();
            }
        }
        if (gameStarted && !creandoPlatforma) {
            creandoPlatforma = true;
            StartCoroutine(Time());
        }
        if (gameStarted && !cuentaPuntos) {
            cuentaPuntos = true;
            StartCoroutine(Punt());
        }
    }

    private IEnumerator Punt() {
        while (true && cuentaPuntos) {
            yield return new WaitForSeconds(1);
            if (cuentaPuntos) {
                puntos += 5;
                puntosTxt.text = puntos.ToString();
            }
        }
    }

    public float PlayerSpeed() {
        return player.GetComponent<PlayerScr>().velocidad;
    }
*/
}

