using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnanascanvasHandler : MonoBehaviour
{
    public TextMeshProUGUI ananasText;
    void Update()
    {
        ananasText.text = GameManager.instance.ananasSayisi.ToString();
    }
}
