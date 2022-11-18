using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    //velocidade
    private float speed = 4f;

    [SerializeField] private GameObject eu;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(eu, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    private void Movimento()
    {
        transform.position += Vector3.left * speed  * Time.deltaTime;
    }

}
