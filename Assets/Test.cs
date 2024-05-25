using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float timer;
    public PlayerAnim anim;
    public int step;
    void Start()
    {
        timer = 0;
        step = 0;
        anim = GetComponent<PlayerAnim>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.5f)
        {
            timer = 0f;
            TestAnimations();
        }
    }

    void TestAnimations()
    {
        switch (step)
        {
            case 0:
                anim.PlayIdle();
                Debug.Log("Playing Idle animation");
                break;
            case 1:
                anim.PlayeWalk();
                Debug.Log("Playing Walk animation");
                break;
            case 2:
                anim.PlayeJump();
                Debug.Log("Playing Jump animation");
                break;
            case 11:
                anim.PlayDie();
                Debug.Log("Playing Die animation");
                break;
            case 12:
                anim.PlayResurgence();
                Debug.Log("Playing Resurgence animation");
                break;
            case 5:
                anim.PlayeAttack(true);
                Debug.Log("Playing Attack animation with walk");
                break;
            case 6:
                anim.PlaySquats(true);
                Debug.Log("Playing Squat animation");
                break;
            case 7:
                anim.PlaySquatWalk();
                Debug.Log("Playing SquatWalk animation");
                break;
            case 8:
                anim.PlaySquatThrow();
                Debug.Log("Playing SquatThrow animation");
                break;
            case 9:
                anim.PlaySquatAttack();
                Debug.Log("Playing SquatAttack animation");
                break;
            case 10:
                anim.PlayUpLook(true, true);
                Debug.Log("Playing UpLook animation with walk and looking up");
                break;
            case 4:
                anim.PlayShootUp(true);
                Debug.Log("Playing ShootUp animation with walk");
                break;
            case 3:
                anim.PlayThrow(true);
                Debug.Log("Playing Throw animation with walk");
                break;
        }

        step = (step + 1) % 14;
    }
}
