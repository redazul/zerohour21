using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject Capsule;
    public bool capsuleOn = true;
    public GameObject Cube;
    public bool cubeOn = true;
    // public GameObject Cylinder;
    // public bool cylinderOn = true;

    public GameObject State1;
    public GameObject State2;
    public GameObject State3;
    public GameObject State4;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("a"))
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

        if(Input.GetKeyDown("d"))
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

        if(capsuleOn ==false && cubeOn==false)
        {
            State1.SetActive(true);
            State2.SetActive(false);
            State3.SetActive(false);
            State4.SetActive(false);
            
        }

        if(capsuleOn ==false && cubeOn==true)
        {
            State1.SetActive(false);
            State2.SetActive(true);
            State3.SetActive(false);
            State4.SetActive(false);
            
        }

                if(capsuleOn ==true && cubeOn==false)
        {

             State1.SetActive(false);
            State2.SetActive(false);
            State3.SetActive(true);
            State4.SetActive(false);
            
        }

                if(capsuleOn ==true && cubeOn==true)
        {

            State1.SetActive(false);
            State2.SetActive(false);
            State3.SetActive(false);
            State4.SetActive(true);
            
        }
       

        // if(Input.GetKeyDown("e"))
        // {
        //                if(cylinderOn)
        //     {
        //     cylinderOn=false;
        //     Cylinder.SetActive(false);
        //     }else{
        //             Cylinder.SetActive(true);
        //              cylinderOn=true;
        //     };
        // }
        
    }
}
