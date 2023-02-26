using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecionarBotao : MonoBehaviour
{
    public static bool olhar = false;

    public void OnPointerEnter()
    {
        olhar = true;
    }

    public void OnPointerExit()
    {
        olhar = false;
    }
}
