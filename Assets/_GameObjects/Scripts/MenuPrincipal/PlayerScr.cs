using System.Collections;
using UnityEngine;

public class PlayerScr : MonoBehaviour {
/*
    public GameManager gm;
    public Animator myAnimator;
    public float velocidad = 0;
    public float fuerzaSalto = 3f;
    private bool onAir = false;
    private float consVelocidad = 0.00001f;
    private float aumentoScroll = 0.001f;
    private float aumentoVelocidadAnimacionCorrer = 1.0f;


    //QUITAMOS EL START
    public void Empezar() {
        velocidad += 0.003f;
        myAnimator.SetBool("GameStart", true);
        if(this.enabled == false) {
            print(" MIERDA PURA");
        }

        StartCoroutine(Clock());
    }

    // Update is called once per frame
    void Update () {
         if(Input.anyKeyDown && !onAir) {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
            onAir = true;
            myAnimator.SetBool("OnAir", true);
        }
	}

    private IEnumerator Clock() {
        while(velocidad <= 0.03f) {
            yield return new WaitForSeconds(10);
            aumentoScroll -= consVelocidad;
            if (aumentoScroll <= 0f) {
                aumentoScroll = 0f;
            }
            velocidad += aumentoScroll;
            gm.musica.pitch += 0.05f;
            aumentoVelocidadAnimacionCorrer += 0.3f;
            if (aumentoVelocidadAnimacionCorrer >= 6f) {
                aumentoVelocidadAnimacionCorrer = 6f;
            }
            myAnimator.SetFloat("SpeedAceleration", aumentoVelocidadAnimacionCorrer);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.otherCollider.GetType() == typeof(BoxCollider2D)) {
            onAir = false;
            myAnimator.SetBool("OnAir", false);
        } else if(!gm.muerteSound.isPlaying) {
            Morir();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.GetType() == typeof(CircleCollider2D)) {
            gm.puntos += 10;
            gm.puntosTxt.text = gm.puntos.ToString();
        } else {
            Morir();
        }
        
    }

    private void Morir() {
       if (!myAnimator.GetBool("PlayerMuerto")){
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            gm.muerteSound.Play();
            gm.musica.Stop();
            gm.cuentaPuntos = false;
            myAnimator.SetBool("PlayerMuerto", true);
            StartCoroutine(Stop());
        }
    }

    private IEnumerator Stop() {
        yield return new WaitForSeconds(0.2f);
        velocidad = 0f;
        StopAllCoroutines();
        gm.Morir();
    }
*/
}



