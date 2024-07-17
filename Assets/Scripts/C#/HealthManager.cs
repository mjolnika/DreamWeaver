using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 5f;

    public void gainDetermination(float determination)
    {
        healthAmount += determination;
        healthBar.fillAmount = healthAmount / 100f;
    }
}
