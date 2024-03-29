using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrolcusu : MonoBehaviour
{
    Vector3 hareketYon;
    public int hiz;
    public int ziplamaGucu;
    Rigidbody2D rb;
    Animator anim;



    void Start()

    { // Verilen bileşen tipini objede arar, eğer obje bu bileşene sahipse bileşeni, sahip değilse null değeri döndürür.(get companent)
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        hareketYon = new Vector3(Input.GetAxis("Horizontal"), 0);
        this.gameObject.transform.position += hareketYon * Time.deltaTime * hiz; //GetAxis=objeyi hareket ettirmek için kullanılır.
        anim.SetFloat("Hiz", Mathf.Abs(Input.GetAxis("Horizontal")));//mutlak değeri dönmeli(abs)



        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rb.velocity.y,0))
        {
            rb.AddForce(transform.up * ziplamaGucu, ForceMode2D.Impulse);
            anim.SetBool("Zipla", true);
        }

        if (anim.GetBool("Zipla") == true && Mathf.Approximately(rb.velocity.y, 0))
        {
            anim.SetBool("Zipla", false);
            //velocity=hız
        }



        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        }
        //Sağa basarsan sağa Sola basarsa sola dönüyor.Karakterin hareket yönü için.

    }


}
