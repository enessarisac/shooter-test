using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    Enemy enemy;
    private void Update() 
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pushed");
            if(Physics.Raycast(ray,out hit))
            { 
                if(hit.collider.tag=="Enemy")
                {
                    Debug.Log("Hit");
                    enemy = hit.collider.gameObject.GetComponent<Enemy>();
                    enemy.TakeDamage(10);
                }
            }
        }
    }
}
