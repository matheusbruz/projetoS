using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pAnimator : MonoBehaviour
{
    //referencias
    Animator am;
    pMovement pm;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<pMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.moveDir.x != 0 || pm.moveDir.y != 0)
        {
            am.SetBool("pMove", true);

            spriteDirChecker();
        }  else
        {
            am.SetBool("pMove", false);
        }
    }

    void spriteDirChecker ()
    {
        if (pm.lastHorizontalVector < 0)
        {
            sr.flipX = true;
        } else
        {
            sr.flipX= false;
        }
    }
}