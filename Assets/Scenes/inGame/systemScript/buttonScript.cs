﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public Transform target_wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, 1.5f);
        Debug.DrawRay(transform.position, transform.right * 1.5f, Color.red);

        if (hit)
        {
            target_wall = hit.transform;

            Vector2 incomingVec = hit.point - new Vector2(transform.position.x, transform.position.y);
        }
        else
            target_wall = null;
    }
    public void onHit()
    {
        if(target_wall != null)
            target_wall.gameObject.GetComponent<Collider2D>().enabled = false;
    }
}
