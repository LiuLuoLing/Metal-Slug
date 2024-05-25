using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator UpAnim;
    private Animator DownAnim;

    void Start()
    {
        UpAnim = transform.Find("UP").GetComponent<Animator>();
        DownAnim = transform.Find("Down").GetComponent<Animator>();
    }

    public void PlayIdle()
    {
        UpAnim.SetBool("Walk", false);
        DownAnim.SetBool("Walk", false);
        PlaySquats(false);
    }

    public void PlayeWalk()
    {
        UpAnim.SetBool("Walk", true);
        DownAnim.SetBool("Walk", true);
        PlaySquats(false);
    }

    /// <summary>
    /// ����
    /// </summary>
    public void PlaySquats(bool state)
    {
        UpAnim.SetBool("Squat", state);
        DownAnim.SetBool("Squat", state);
    }

    /// <summary>
    /// ��
    /// </summary>
    public void PlayeJump()
    {
        UpAnim.SetTrigger("Jump");
        DownAnim.SetTrigger("Jump");
    }

    /// <summary>
    /// ����
    /// </summary>
    public void PlayDie()
    {
        UpAnim.gameObject.SetActive(false);
        DownAnim.SetTrigger("Die");
    }

    /// <summary>
    ///����
    /// </summary>
    public void PlayResurgence()
    {
        UpAnim.gameObject.SetActive(true);
        DownAnim.SetTrigger("Resurgence");
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="isWalking">�Ƿ���</param>
    public void PlayeAttack(bool isWalking)
    {
        UpAnim.SetTrigger("Attack");
        DownAnim.SetBool("Walk", isWalking);
    }

    /// <summary>
    /// ������
    /// </summary>
    public void PlaySquatWalk()
    {
        UpAnim.SetBool("Squat", true);
        DownAnim.SetBool("SquatWalk", true);
    }

    /// <summary>
    /// ���Ŷ�����
    /// </summary>
    public void PlaySquatThrow()
    {
        UpAnim.SetTrigger("SquatAttack");
    }

    /// <summary>
    /// ���Ź���
    /// </summary>
    public void PlaySquatAttack()
    {
        UpAnim.SetTrigger("SquatThrow");
    }

    /// <summary>
    /// ���Ͽ�
    /// </summary>
    public void PlayUpLook(bool isWalking, bool upLook)
    {
        UpAnim.SetBool("Up", upLook);
        DownAnim.SetBool("Walk", isWalking);
        PlaySquats(false);
        DownAnim.SetBool("SquatWalk", false);
    }

    /// <summary>
    /// �������
    /// </summary>
    /// <param name="isWalking">�Ƿ���</param>
    public void PlayShootUp(bool isWalking)
    {
        UpAnim.SetTrigger("ShootUp");
        DownAnim.SetBool("Walk", isWalking);
        PlaySquats(false);
        DownAnim.SetBool("SquatWalk", false);
    }

    /// <summary>
    /// Ͷ��
    /// </summary>
    public void PlayThrow(bool isWalking)
    {
        UpAnim.SetBool("Up", false);
        UpAnim.SetTrigger("Throw");
        DownAnim.SetBool("Walk", isWalking);
    }
}
