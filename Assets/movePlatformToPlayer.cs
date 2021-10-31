using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatformToPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // /Debug.Log(this.transform.position.y);
        transform.Translate(0, 2 * Time.deltaTime, 0);
    }
}
