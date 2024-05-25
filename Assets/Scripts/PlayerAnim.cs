using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator upAnim;
    private Animator downAnim;

    void Start()
    {
        upAnim = transform.Find("UP").GetComponent<Animator>();
        downAnim = transform.Find("Down").GetComponent<Animator>();
    }

    public void PlayIdle()
    {
        upAnim.SetBool("Walk", false);
        downAnim.SetBool("Walk", false);
        PlaySquats(false);
        upAnim.SetBool("Up", false);
    }

    public void PlayeWalk()
    {
        upAnim.SetBool("Walk", true);
        downAnim.SetBool("Walk", true);
        PlaySquats(false);
        upAnim.SetBool("Up", false);
    }

    /// <summary>
    /// ����
    /// </summary>
    public void PlaySquats(bool state)
    {
        upAnim.SetBool("Squat", state);
        downAnim.SetBool("Squat", state);
    }

    /// <summary>
    /// ��
    /// </summary>
    public void PlayeJump()
    {
        upAnim.SetTrigger("Jump");
        downAnim.SetTrigger("Jump");
    }

    /// <summary>
    /// ����
    /// </summary>
    public void PlayDie()
    {
        upAnim.gameObject.SetActive(false);
        downAnim.SetTrigger("Die");
    }

    /// <summary>
    ///����
    /// </summary>
    public void PlayResurgence()
    {
        upAnim.gameObject.SetActive(true);
        downAnim.SetTrigger("Resurgence");
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="isWalking">�Ƿ���</param>
    public void PlayeAttack(bool isWalking)
    {
        upAnim.SetTrigger("Attack");
        downAnim.SetBool("Walk", isWalking);
    }

    /// <summary>
    /// ������
    /// </summary>
    public void PlaySquatsWalk()
    {
        upAnim.SetBool("Squat", true);
        downAnim.SetBool("SquatWalk", true);
    }

    /// <summary>
    /// ���Ŷ�����
    /// </summary>
    public void PlaySquatsThrow()
    {
        upAnim.SetTrigger("SquatAttack");
    }

    /// <summary>
    /// ���Ź���
    /// </summary>
    public void PlaySquatsAttack()
    {
        upAnim.SetTrigger("SquatThrow");
    }

    /// <summary>
    /// ���Ͽ�
    /// </summary>
    public void PlayUpLook(bool isWalking)
    {
        upAnim.SetBool("Up", true);
        downAnim.SetBool("Walk", isWalking);
        PlaySquats(false);
        downAnim.SetBool("SquatWalk", false);
    }

    /// <summary>
    /// �������
    /// </summary>
    /// <param name="isWalking">�Ƿ���</param>
    public void PlayShootUp(bool isWalking)
    {
        upAnim.SetTrigger("ShootUp");
        downAnim.SetBool("Walk", isWalking);
        PlaySquats(false);
        downAnim.SetBool("SquatWalk", false);
    }

    /// <summary>
    /// Ͷ��
    /// </summary>
    public void PlayThrow(bool isWalking)
    {
        upAnim.SetBool("Up", false);
        upAnim.SetTrigger("Throw");
        downAnim.SetBool("Walk", isWalking);
    }
}
