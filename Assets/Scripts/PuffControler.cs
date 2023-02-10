using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuffControler : MonoBehaviour
{

    private Transform meuTransform;
    private Transform playerTransform;
    private PlayerController player;
    [SerializeField] private GameObject eu;

    private Vector3 fumacaPos;


    // Start is called before the first frame update
    void Start()
    {
       player = FindObjectOfType<PlayerController>();
       playerTransform = player.transform;
       meuTransform = GetComponent<Transform>();
       fumacaPos = playerTransform.position;
       fumacaPos.x = -16.5f;
       meuTransform.position = fumacaPos;

       Destroy(eu, 1f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
