﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularBullet : Bullet
{
    protected Rigidbody2D rigidBody2d;

    public override BulletDataSO BulletData 
    { 
        get => base.BulletData;
        set
        {
            base.BulletData = value;
            rigidBody2d = GetComponent<Rigidbody2D>();
            rigidBody2d.drag = BulletData.Friction;
        }
    }

    private void FixedUpdate()
    {
        if(rigidBody2d != null && BulletData != null)
        {
            rigidBody2d.MovePosition(transform.position + BulletData.BulletSpeed * transform.right * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            HitObstacle();
        }
        Destroy(gameObject);
    }

    private void HitObstacle()
    {
        Debug.Log("Hitting obstacle");
    }
}
