using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{

    public BoxCollider2D collider;
    public Rigidbody2D rb;

    private float width;
    private float scrollSpeed = -5f;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

      //  rb.velocity = new Vector2(scrollSpeed, 0);

        ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {

      rb.velocity = new Vector2(scrollSpeed, 0);


        if (transform.position.x < -width)
        {
          Vector2 resetPosition = new Vector2(width * 2f,0);
          transform.position = (Vector2)transform.position + resetPosition;
          ResetObstacle();
        }

        timer += Time.deltaTime;

        if (timer > 12f)
        {
          scrollSpeed -= 2;
          timer = 0;
        }

    }

    void ResetObstacle() {
        transform.GetChild(0).localPosition = new Vector3(0, Random.Range(-4,4),0);
    }
}
