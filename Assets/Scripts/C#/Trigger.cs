using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{ 
    private AudioSource ingameAudioSource;

    [SerializeField] private AudioClip puzzleSolvedSound;
    [SerializeField] private AudioClip buttonClickedSound;
    [SerializeField] public Puzzle puzzle;

    // Start is called before the first frame update

    void Start()
    {
        puzzle.triggers.Add(this);
        puzzle.check.Add(false);
        ingameAudioSource = GetComponent<AudioSource>();
    }

    void  UpdateBarrier()
    {
        var index = puzzle.triggers.IndexOf(this);
        if (puzzle.check[index] == false)
        {
            puzzle.triggered++;
            puzzle.check[index] = true;
        }
        

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
        else
        {
            ingameAudioSource.PlayOneShot(buttonClickedSound);
        }
    }
    public void OnTriggerStay2D(Collider2D other) // UPDATE: add animation to tiggers
    {

        if (other.gameObject.tag == "Player")
        {
            UpdateBarrier();
        }
    }

    void HideBarrier()
    {
        ingameAudioSource.PlayOneShot(puzzleSolvedSound);
        puzzle.gameObject.SetActive(false);
    }
    
}
