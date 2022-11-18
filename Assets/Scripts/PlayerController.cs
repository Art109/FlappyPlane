using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D meuRB;

    //Velocida
    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Subir();

        limitadorVelocidade();

    
        
    }

    private void limitadorVelocidade()
    {
        if (meuRB.velocity.y < -speed)
        {
            meuRB.velocity = Vector2.down * speed;
        }
    }

    private void Subir() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            meuRB.velocity = Vector2.up * speed;
        }
    }


    //Configurando a colisão para morte
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Jogo");
    }
}
