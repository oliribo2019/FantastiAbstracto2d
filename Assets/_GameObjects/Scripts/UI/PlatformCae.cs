using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCae : MonoBehaviour
{   
    private bool empiezoAcaer = false;
    private Color actualColor;
    private float fullColor = 1f;
    public float delay;    
    private float distance;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!empiezoAcaer)
        {
            empiezoAcaer = true;
            //actualColor = this.GetComponent<SpriteRenderer>().color;
            Invoke("IniciarCaida", delay);
            StartCoroutine(Time());
        }
    }

    private void Update()
    {
        if (empiezoAcaer)
        {
            GetComponent<PlatformColor>().enabled = false;
            fullColor -= 0.01f;
            GetComponent<SpriteRenderer>().color = new Color(fullColor, fullColor, fullColor);
        }
    }

    private IEnumerator Time()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
    }

}
