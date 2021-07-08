using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown: MonoBehaviour
{
    Rigidbody2D tileRB;
    [SerializeField]
    float moveSpeed;

    private void Start()
    {
        tileRB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        tileRB.velocity = Vector2.left * moveSpeed;
    }


    private void Update()
    {
        if (transform.position.x < -3.5f)
        {
            this.gameObject.SetActive(false);
        }
    }

}
