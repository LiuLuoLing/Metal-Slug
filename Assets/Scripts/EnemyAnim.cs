using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayDie()
    {
        animator.SetTrigger("Die");
    }

    public void PlayAttack()
    {
        animator.SetTrigger("Kill");
    }

    public void PlayRun()
    {
        animator.SetTrigger("Walking");
    }

    public void PlayIdle()
    {
        animator.SetTrigger("Idle");
    }
}
