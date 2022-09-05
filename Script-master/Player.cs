using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float Speed;
    public float JumpForce;
    private Rigidbody2D rig;
    public bool PoderSaltar;
    public bool PuloDuplo;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Pular();
    }

    // Para fazer o personagem movimentar na horizontal
    void Move()
    {
        Vector3 movemet = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movemet * Time.deltaTime * Speed;
    }

    void Pular()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
          //  poderSaltar = false;
        }
        
            if(PuloDuplo)
            {
                rig.AddForce(new Vector2(0f, JumpForce),ForceMode2D.Impulse);
                PuloDuplo = false;
            }

        if ( Input.GetButtonDown("Fire2"))
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D collision){
         if(collision.gameObject.layer == 8){
             PoderSaltar = false;
         }
    }

    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.layer == 8){
            PoderSaltar = true;
        }
    }

}
