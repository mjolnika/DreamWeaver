using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Trigger> triggers;
    public List<bool> check;
    public int triggered = 0;
    
    void Start()
    {
        foreach (Trigger trigger in triggers)
        {
            check.Add(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
