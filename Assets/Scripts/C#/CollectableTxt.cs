using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableTxt : MonoBehaviour
{
    [SerializeField] public PlayerController player;
    public Text collectableTxt;

    void Start()
    {
    }

    void Update()
    {
        collectableTxt.text = string.Format("{0}", player.counter);
    }

}
