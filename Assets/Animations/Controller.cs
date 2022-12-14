using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private void Update()
    {
        var animator = GetComponent<Animator>();
        animator.SetFloat("X-axis", Input.GetAxis("Horizontal"));
        animator.SetFloat("Y-axis", Input.GetAxis("Vertical"));
    }
}
