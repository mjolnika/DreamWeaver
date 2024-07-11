using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Trigger> triggers;
    //public GameObject barrier;
    public List<bool> check;


    
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
