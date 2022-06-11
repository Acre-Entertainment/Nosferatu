using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenryFix : MonoBehaviour
{
    public float posX, posY, posZ, rotX, rotY, rotZ;
    Vector3 position;
    Vector3 rotation;
    private void Start()
    {
        position = new Vector3(posX, posY, posZ);
        rotation = new Vector3(rotX, rotY, rotZ);
    }
    private void Update() {
        gameObject.transform.localPosition = position;
        gameObject.transform.localEulerAngles = rotation;
    }
    public void ChangeValues(float px, float py, float pz, float rx, float ry, float rz)
    {
        posX = posX + px;
        posY = posY + py;
        posZ = posZ + pz;
        rotX = rotX + rx;
        rotY = rotY + ry;
        rotZ = rotZ + rz;

        position = new Vector3(posX, posY, posZ);
        rotation = new Vector3(rotX, rotY, rotZ);
    }
}
