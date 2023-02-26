using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public bool gazeAtFloor = false;

    public void OnPointerEnter()
    {
        gazeAtFloor = true;
    }

    public void OnPointerExit()
    {
        gazeAtFloor = false;
    }
}
