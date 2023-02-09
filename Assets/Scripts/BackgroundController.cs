using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    // Start is called before the first frame update

    // Variavel do Componente do Material
    private Renderer fundo;

    // Varivel do offset X da Textura
    private float offsetX = 0f;
    // Offset da textura
    private Vector2 offset;

    //Velocidade do fundo
    private float speed = 0.5f;

    void Start()
    {
        fundo = GetComponent<Renderer>();

        offset = fundo.material.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
        offsetX += speed * Time.deltaTime;

        offset.x = offsetX;

        fundo.material.mainTextureOffset = offset;

    }
}
