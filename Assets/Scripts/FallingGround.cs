using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGround : MonoBehaviour
{

    private Rigidbody2D fallingGround;
    private bool m_UseGravity;

    // Start is called before the first frame update
    void Start()
    {
        fallingGround = this.GetComponent<Rigidbody2D>();
        m_UseGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_UseGravity) {
            fallingGround.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void DestroyGameObject() {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            m_UseGravity = true;
        } else if (collision.gameObject.CompareTag("Floor")) {
            this.DestroyGameObject();
        }
    }
}
