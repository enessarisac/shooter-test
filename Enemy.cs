using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IEnemy
{
    public int health;
    public void TakeDamage(int damage)
    {
        health-=damage;
        if(health<=0)
        {
            Die();
        }
    }

    private void Die()
    {
        var ragdollSetter = GetComponent<RagdollSetter>();
        ragdollSetter.EnableRagdoll();
        this.gameObject.tag="Untagged";
    }
}

