using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desativador : MonoBehaviour
{
    public GameObject objeto;
    public bool objetoBool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && objetoBool == true)
        {
            FindObjectOfType<AudioManager>().Play("Ativador");
            objeto.SetActive(true);
            objetoBool = false;
        }
        else if(other.CompareTag("Player") && objetoBool == false)
        {
            objeto.SetActive(false);
            objetoBool = true;
        }
    }
}
