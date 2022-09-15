using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;

    public float jumpForce = 10;

    private bool isGround = true;

    private float speed = 0.5f;

    public bool gameOver = false;

    private Animator playerAnim;

    //private float horizontalInput;

    [SerializeField]
    private float gravityModifier;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    private void Start()
    {
        Physics.gravity *= gravityModifier;
    }

    private void Update()
    {

        //horizontalInput = Input.GetAxis("Horizontal");

        if (!gameOver)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }


        if (Input.GetKeyDown(KeyCode.Space) && isGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacles"))
        {
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);

            Debug.Log(gameOver);
        }
    }
}
