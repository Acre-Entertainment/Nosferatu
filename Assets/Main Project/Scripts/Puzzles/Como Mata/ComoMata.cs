using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ComoMata : MonoBehaviour
{
    public Table book1, book2, cast1, cast2;
    public UnityEvent onPuzzleComplete1;
    public UnityEvent onPuzzleComplete2;
    public void checkAndAct1()
    {
        if(book1.hasBook == true && book2.hasBook == true && cast1.hasCast == true && cast2.hasCast)
        {
            onPuzzleComplete1.Invoke();
        }
    }
}
