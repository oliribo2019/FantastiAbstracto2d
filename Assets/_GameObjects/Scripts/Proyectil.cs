using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float force;
    public int damage;
      

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision.gameObject me proporciona el objeto con el que ha colisionado
        if (collision.gameObject.CompareTag(Tags.ENEMY))
        {
            //Es un enemigo
            //collision.gameObject.GetComponent<Bee>().ReceiveDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
