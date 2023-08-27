using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_animation : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        animator.SetTrigger("Animate");
    }
}
