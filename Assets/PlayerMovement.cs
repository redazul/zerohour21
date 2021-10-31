using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * Horizontal * MoveSpeed * Time.deltaTime);
    }
}
