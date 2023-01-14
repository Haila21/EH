using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControoler : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    // Start is called before the first frame update
    private void Update(){                  //Start() press w to move forward
    
     if (Input.GetKeyDown(KeyCode.D))   transform.position += Vector3.forward;


   var dir = new Vector3( Input.GetAxis("Horizontal"), 0 , Input.GetAxis("Vertical"));

    transform.Translate(dir *_speed* Time.deltaTime);

    }

      


}















