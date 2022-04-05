using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpurrarObjetos : MonoBehaviour
{
    //Variavel para checar se o objeto � filho do player
    public bool isChild;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se o objeto for filho do player e o bot�o for apertado, ele n�o � mais filho do player
        if (Input.GetKeyDown(KeyCode.Return) && isChild)
        {
            isChild = false;
            this.transform.SetParent(null);
        }
    }

    //Checa quando o Detected Area esta em contato com o objeto
    private void OnTriggerStay(Collider other)
    {
        //Se o objeto entrar em colis�o com o player e se o bot�o for apertado, ele se torna filho do player
        if (other.CompareTag("Detected Area") && Input.GetKeyDown(KeyCode.Space))
        {
            isChild = true;
            this.transform.SetParent(other.transform);
        }
    }
}
