using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    
    public void SetHealth(float current, float max = 100)
    {
        healthBar.fillAmount = current / max;
    }

    public void SetAmount (float current, float max = 100)
    {
        healthBar.fillAmount = current / max;
    }
}
