using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D rb;
     Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        //flip character
        Vector3 characterScale = transform.localScale;
        if (movement.x < 0)
        {
            characterScale.x = -1;
        }

        if (movement.x > 0)
        {
            characterScale.x = 1;
        }

        if (movement.y < 0)
        {
            characterScale.y = -1;
        }

        if (movement.y > 0)
        {
            characterScale.y = 1;
        }
    }
}
