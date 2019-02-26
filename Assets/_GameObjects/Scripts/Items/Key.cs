using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Item
{
    public int points;
    
    public override void Kill()
    {
        Destroy(this.gameObject);
        base.Kill();
        
    }
    public override void DoAction()
    {
        base.DoAction();

        GameManager.AddPoints(points);
        Kill();
    }
}
