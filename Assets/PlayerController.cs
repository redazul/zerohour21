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

    void Update()
    {

        if(Input.GetKeyDown("q")) Capsule.SetActive(!Capsule.active);

        if(Input.GetKeyDown("w")) Cube.SetActive(!Cube.active);

        if(Input.GetKeyDown("e")) Cylinder.SetActive(!Cylinder.active);
        
    }
}
