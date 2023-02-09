using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    //velocidade
    private float speed = 4f;

    [SerializeField] private GameObject eu;

    [SerializeField] private GameController game;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(eu, 6f);

        game = FindObjectOfType<GameController>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();

        speed = 4f + game.getLevel();
    }

    private void Movimento()
    {
        transform.position += Vector3.left * speed  * Time.deltaTime;
    }

}
