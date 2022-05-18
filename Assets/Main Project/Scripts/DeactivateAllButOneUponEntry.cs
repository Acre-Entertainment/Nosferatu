using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateAllButOneUponEntry : MonoBehaviour
{
    public List<GameObject> objectList;
    public void deactivateAllButOne(int x)
    {
        foreach(GameObject go in objectList)
        {
            go.SetActive(false);
        }
        objectList[x].SetActive(true);
    }
}
