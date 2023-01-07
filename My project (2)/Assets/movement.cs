using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private CharacterController charactercontroller;
    public Transform cam;
    public float Speed;
    public Animator anim;
    float Verticalmovement;
    float Horizontalmovement;
    public float turnSmoothTime=0.1f;
    float turnSmoothVelocity;

    public float gravity=-9.81f;
    Vector3 Velocity;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        charactercontroller=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
     
        anim.SetFloat("walkingHorizontal", Input.GetAxis("Horizontal"));
        anim.SetFloat("WalkingVertical", Input.GetAxis("Vertical"));
        Speed = 3;
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        
        if (movement.magnitude>=0.1f){
            
                    float targetAngle=Mathf.Atan2(movement.x,movement.z)*Mathf.Rad2Deg+cam.eulerAngles.y;
                    float angle=Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle,ref turnSmoothVelocity,turnSmoothTime);
                    transform.rotation=Quaternion.Euler(0f,angle,0f);

                    Vector3 moveDir=Quaternion.Euler(0f,targetAngle,0f)*Vector3.forward;
                    charactercontroller.Move(moveDir.normalized*Speed*Time.deltaTime);
                    
                    Velocity.y+=gravity*Time.deltaTime;
                    charactercontroller.Move(Velocity*Time.deltaTime);
    }
    }
}
