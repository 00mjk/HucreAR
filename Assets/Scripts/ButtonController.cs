using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject InfoPanel;

    public void ClosePanel()
    {
        InfoPanel.SetActive(false);
    }
}
