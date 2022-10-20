using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAviao : MonoBehaviour
{
    public GameObject aviao;
    public float velocidade = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Método que é chamado quando a tela é atualizada
    void Update()
    {
        
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(new Vector3(0, Time.deltaTime * velocidade, 0));
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(new Vector3(0,-Time.deltaTime * velocidade, 0));
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3(-Time.deltaTime * velocidade, 0,0));
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3(Time.deltaTime*velocidade,0,0));
        }

    }
}
