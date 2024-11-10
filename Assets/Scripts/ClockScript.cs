using UnityEngine;
using TMPro;
using System;

public class DigitalClock : MonoBehaviour
{
    public TextMeshProUGUI clockText;

    void Update()
    {
        DateTime currentTime = DateTime.Now;
        clockText.text = currentTime.ToString("HH:mm:ss");
    }
}
