using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeradorController : MonoBehaviour
{

    //Inicializando o Timer
    private float timer = 1f;

    //Posição do inicio do obstaculo
    [SerializeField]private Vector3 posicao ;

    // Limites dos obstaculos
    private float posMin = -1.87f;
    private float posMax = 1.32f;

    // Montanha
    [SerializeField] private GameObject obstaculo;

    // Pontos
    private float pontos = 0f;
    [SerializeField] private Text pontosText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CriaObstaculo();
        ContadorPontos();

    }


    private void CriaObstaculo() 
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {

            posicao.y = Random.Range(posMin, posMax);

            Instantiate(obstaculo, posicao , Quaternion.identity);

            timer = Random.Range(1f,2f);
        }
    }

    private void ContadorPontos()
    {
        pontos += Time.deltaTime;
        pontosText.text = Mathf.Round(pontos).ToString();
    }
}
