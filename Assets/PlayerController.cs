using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject Capsule;
    public bool capsuleOn = true;
    public GameObject Cube;
    public bool cubeOn = true;
    public GameObject Cylinder;
    public bool cylinderOn = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("q"))
        {
            if(capsuleOn)
            {
            capsuleOn=false;
            Capsule.SetActive(false);
            }else{
                    Capsule.SetActive(true);
                    capsuleOn=true;
            }
        }

        if(Input.GetKeyDown("w"))
        {
                        if(cubeOn)
            {
            
            cubeOn=false;
            Cube.SetActive(false);
            }else{
                    Cube.SetActive(true);
                     cubeOn=true;
            }
        }

        if(Input.GetKeyDown("e"))
        {
                       if(cylinderOn)
            {
            cylinderOn=false;
            Cylinder.SetActive(false);
            }else{
                    Cylinder.SetActive(true);
                     cylinderOn=true;
            };
        }
        
    }
}
