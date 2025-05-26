using Unity.VisualScripting;
using UnityEngine;

public class LittleCircle : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public bool isMovementRestricted;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isMovementRestricted == false)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "BigCircle")
        {
            isMovementRestricted = true;
        }
    }
}
