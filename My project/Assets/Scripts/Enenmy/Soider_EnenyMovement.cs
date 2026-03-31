using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soider_EnenyMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public Transform player;
    public Transform Base;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//start rb
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (Base.position - transform.position).normalized;
        rb.velocity = direction * speed;

    }

}
