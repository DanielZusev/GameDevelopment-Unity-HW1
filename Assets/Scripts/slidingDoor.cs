using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidingDoor : MonoBehaviour
{

    private Animator animator;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("DoorOpening", true);
        audio.PlayDelayed(0.8f);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("DoorOpening", false);
        audio.PlayDelayed(0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
