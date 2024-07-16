using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTxt : MonoBehaviour
{
    [SerializeField] public Puzzle puzzle;
    public Text buttonTxt;
    int buttonCount;
    int buttonTriggered;

    void Start()
    {
    }
   
    void Update()
    {
        buttonCount = puzzle.check.Count;
        buttonTriggered = puzzle.triggered;
        buttonTxt.text = string.Format("{0}/{1}", buttonTriggered, buttonCount);
    }

}
