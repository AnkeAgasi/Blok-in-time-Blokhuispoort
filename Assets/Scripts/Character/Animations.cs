using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animations : MonoBehaviour
{
    Animator anim;

void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) { anim.SetBool ("isJump", true);}
        else{ anim.SetBool("isJump", false);}

        if ((Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.DownArrow)))
    {
anim.SetBool("isRun",true);
}
else
{  anim.SetBool("isRun", false);}
    }
    
    }
