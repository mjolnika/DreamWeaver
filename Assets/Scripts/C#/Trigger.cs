using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour

{
    [SerializeField] public Puzzle puzzle;
    // Start is called before the first frame update
    void Start()
    {
        puzzle.triggers.Add(this);
    }

    void  UpdateBarrier()
    {
        var index = puzzle.triggers.IndexOf(this);
        puzzle.check[index] = true;

       // var allTriggered = CheckTriggered();
        var allTriggered = true;
        for (int i = 0; i < puzzle.check.Count; i++)
        {
            if (puzzle.check[i] == false)
            {
                allTriggered = false;
                break;
            }
        }

        if (allTriggered)
        {
            HideBarrier();
        }
    }
    public void OnTriggerStay2D(Collider2D other) // UPDATE: add animation to tiggers
    {

        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                UpdateBarrier();
            }
        }
    }

    void HideBarrier()
    {
        puzzle.gameObject.SetActive(false);
    }
    
}
