using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatorr : MonoBehaviour
{
    Animator animator;
    Vector2 Movement;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();



    }

    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxis("Horizontal");
        Movement.y = Input.GetAxis("Vertical");

        animator.SetFloat("Move", Movement.x);
    }
}
