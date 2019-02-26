using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : Item {
    public int points;
    
    Vector3 initPos;
    [SerializeField] Transform endPos;
    [SerializeField] int health;
    [SerializeField] float speed;
    float pct = 0;

    private void Awake()
    {
        initPos = transform.position;
    }

    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.PLAYER))
        {
            print("choque con la abeja");
            collision.gameObject.GetComponent<Player>().ReceiveDamage(health);
            
        }
    }
    public override void Kill()
    {
        base.Kill();
        Destroy(this.gameObject);
    }
    public override void DoAction()
    {
        base.DoAction();
        //GameManager.AddPoints(points);
        Kill();
    }
}
