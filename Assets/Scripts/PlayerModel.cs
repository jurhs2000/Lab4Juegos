﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{

    public Animator gunAnimator;
    // Start is called before the first frame update
    void Start()
    {
        gunAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gunAnimator.Play("Shoot");
        }
    }
}
