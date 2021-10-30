using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public float velocidad = 10.0f;
    public float JumpForce;

    private Animator Animator;
    private Rigidbody2D Rigidbody2D;
    private float horizontal;
    private bool grounded;

    public string nivel;

    public static int vida = 3;

    public GameObject MuerteUI;

    void Start()
    {
        Animator = GetComponent<Animator>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var escena = SceneManager.GetActiveScene().name;
        nivel = SceneManager.GetActiveScene().name;

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(escena.ToString());
            vida = 3;
            return;
        }

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.5f) && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown("up")))
        {
            Rigidbody2D.AddForce(Vector2.up * JumpForce);
        }

        horizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        transform.Translate(horizontal, 0f, 0f);
        Animator.SetBool("Walking", horizontal != 0.0f);
        if (horizontal != 0.0f)
        {
            transform.localScale = new Vector3(horizontal < 0.0f ? 2.0f : -2.0f, 2f, 2f);
        }

        Animator.SetBool("Muerte", vida == 0);

    }

    public void Golpe()
    {
        if (--vida == 0)
        {
            MuerteUI.SetActive(true);
            vida = 3;
            Time.timeScale = 0f;
        }
    }

    public void MasVida()
    {
        vida++;
    }

    public void tp()
    {
        transform.position = new Vector3(96.65f, 42.67f, 0f);
    }

}
