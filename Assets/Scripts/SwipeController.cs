using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{

    Vector3 clickInicial;
    Vector3 alSoltarClick;
    [SerializeField]
    float offset = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) 
        {
            clickInicial = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            alSoltarClick = Input.mousePosition;
            Debug.Log("Posición Inicial " + clickInicial + " posición final " + alSoltarClick);
            Vector3 diferencia = alSoltarClick - clickInicial;
            Debug.Log(diferencia);

            if (diferencia.x < -offset)
            {
                MoveTarget(-cube.GetComponent )
            }
            if (diferencia.x > offset)
            {
                Debug.Log("Se ha movido a la derecha");
            }
            if (diferencia.y < -offset)
            {
                Debug.Log("Se ha movido hacia abajo");
            }
            if (diferencia.y > offset)
            {
                Debug.Log("Se ha movido hacia arriba");
            }
        }
    }

    void MoveTarget(Vector3 direction)
    {
        cube.transform.position += direction;
    }
}
