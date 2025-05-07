using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateComponet : MonoBehaviour
{
    Animator animator;
    float velocity=0.0f;
    public float acceleration =0.1f;
    public float deceleration =0.5f;
    
    int isWalkingHash;
    int isRunningHash;
    int velocityHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        velocityHash = Animator.StringToHash("velocity");

    }

    void Update()
    {
        // bool isWalking = animator.GetBool(isWalkingHash);
        // bool isRunning = animator.GetBool(isRunningHash);
        bool forward = Input.GetKey("w");
        bool RunPressed = Input.GetKey("left shift");

        if(forward && velocity<1.0f){
            velocity+=Time.deltaTime*acceleration;
        }
        if(!forward && velocity>0){
            velocity-=Time.deltaTime*deceleration;
        }
        if(!forward && velocity<0.0f){
            velocity=0.0f;
        }
        animator.SetFloat(velocityHash, velocity);
        // if (!isWalking && forward)
        // {
        //     animator.SetBool(isWalkingHash, true);

        // }
        // if (isWalking && !forward)
        // {
        //     animator.SetBool(isWalkingHash, false);
        // }
        // if (!isRunning && forward && RunPressed)
        // {
        //     animator.SetBool(isRunningHash, true);
        // }
        // if (isRunning && (!forward || !RunPressed))
        // {
        //     animator.SetBool(isRunningHash, false);
        // }





    }
}
