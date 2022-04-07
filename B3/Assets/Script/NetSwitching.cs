using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetSwitching : MonoBehaviour
{
    public Animator Net;
    //public GameObject Net;
    private bool Player;
    private bool State;
    private bool PreviousPlayer;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        Player = false;
        State = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Player && Player != PreviousPlayer && time + 10 < Time.time)
        {
            State = !State;
            Net.SetBool("net", State);
            time = Time.time;
        }
        PreviousPlayer = Player;
    }
    private void OnTriggerEnter(Collider other)
    {
        
        Player = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Player = false;
    }
}
