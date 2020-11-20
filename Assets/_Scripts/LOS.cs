﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LOS : MonoBehaviour
{
    public Collider2D collidesWith;
    public ContactFilter2D contactFilter;
    public List<Collider2D> colliders;

    private BoxCollider2D LOSCollider;

    // Start is called before the first frame update
    void Start()
    {
        LOSCollider = GetComponent<BoxCollider2D>();
    }   

    // Update is called once per frame
    void FixedUpdate()
    {
        Physics2D.GetContacts(LOSCollider, contactFilter, colliders); // Every frame, fill up colliders list 
    }

    private void OnTriggerEenter2D(Collider2D other)
    {
        collidesWith = other;
    }
}