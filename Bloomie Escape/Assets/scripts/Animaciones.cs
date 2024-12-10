using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    [SerializeField] float altura;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector3 PosicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Parametro1", true);
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * altura);
        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Parametro1", false);
        if (collision.transform.tag == "enemigo")
        {
            GameManager.Instancia.Perder();
        }

    }
}
