using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChairPuzzle : ObjectEvent
{
    public UnityEvent onPuzzleSolved;
    public GameObject chair1, chair2, chair3, chair4, chair5, chair6, chair7, chair8, chair9, chair10;
    public Chairs chairs1, chairs2, chairs3, chairs4, chairs5, chairs6, chairs7, chairs8, chairs9, chairs10;
    public bool puzzleIsSolved;
    // Start is called before the first frame update
    void Start()
    {
        chairs1 = chair1.GetComponent<Chairs>();
        chairs2 = chair2.GetComponent<Chairs>();
        chairs3 = chair3.GetComponent<Chairs>();
        chairs4 = chair4.GetComponent<Chairs>();
        chairs5 = chair5.GetComponent<Chairs>();
        chairs6 = chair6.GetComponent<Chairs>();
        chairs7 = chair7.GetComponent<Chairs>();
        chairs8 = chair8.GetComponent<Chairs>();
        chairs9 = chair9.GetComponent<Chairs>();
        chairs10 = chair10.GetComponent<Chairs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (chairs1.chairIsOk && chairs2.chairIsOk && chairs3.chairIsOk && chairs4.chairIsOk && chairs5.chairIsOk && chairs6.chairIsOk && chairs7.chairIsOk && chairs8.chairIsOk && chairs9.chairIsOk && chairs10.chairIsOk)
        {
            puzzleIsSolved = true;
            onPuzzleSolved.Invoke();
        }
        else
        {
            puzzleIsSolved = false;
        }
    }
}
