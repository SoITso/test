﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class アイテム : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}