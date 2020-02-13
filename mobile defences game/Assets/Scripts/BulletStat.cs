using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStat
{

    public int damage { get; set; }
    public float speed { get; set; }

    public BulletStat(float speed, int damage)
    {
        this.speed = speed;
        this.damage = damage;
    }
    
}
