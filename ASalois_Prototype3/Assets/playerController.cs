using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed = 5;
    public float playerLife = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0, moveDirection * moveSpeed);

      //  float moveDirectionSide = Input.GetAxisRaw("Horizontal");
      //  rb.velocity = new Vector3(moveDirectionSide, 0 * moveSpeed);

    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Obstacle")) {
            playerLife -= 1;
            Debug.Log(playerLife);
        }

        if(playerLife == 0) {
          Destroy(gameObject);
        }
    }
}
