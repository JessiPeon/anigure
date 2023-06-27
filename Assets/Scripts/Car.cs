using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public bool isGrounded;
    public bool isUpsideDown;
    public LayerMask groundLayer;

    public Transform upPos;
    public Transform downPos;

    private void Update()
    {
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector2.down, out hit, raycastDistance, groundLayer))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }*/
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 1.5f, transform.position.y - 1.5f), new Vector2(transform.position.x + 1.5f, transform.position.y - 1.51f), groundLayer);
        if(upPos.position.y < downPos.position.y)
        {
            isUpsideDown = true;
            SceneManager.LoadScene("BadFinal");
        }
        if (Input.GetMouseButton(0) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
