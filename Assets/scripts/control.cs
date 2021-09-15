using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{

    float horizontal;

    public float velocidad = 10.0f;
    public float JumpForce;

    private Animator Animator;
    private Rigidbody2D Rigidbody2D;

    private bool grounded;

    public static int vida = 3;

    void Start()
    {
        Animator = GetComponent<Animator>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        transform.Translate(horizontal, 0f, 0f);

        Animator.SetBool("Walking", horizontal != 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.5f))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        if (horizontal < 0.0f) {
            transform.localScale = new Vector3(2.0f, 2f, 2f);
        }
        else if (horizontal > 0.0f)
        {
            transform.localScale = new Vector3(-2.0f, 2f, 2f);
        }

        if (Input.GetKeyDown(KeyCode.W) && grounded == true)
        {
            Jump();
        }

        void Jump() => Rigidbody2D.AddForce(Vector2.up * JumpForce);


        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Golpe()
    {
        vida = vida - 1;
        if (vida == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MENUPRINCIPAL");
        }
    }
            
}
