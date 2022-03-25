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
    // Start is called before the first frame update
    void Start()
    {
        Player = false;
        State = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Player && Player != PreviousPlayer)
        {
            State = !State;
            Net.SetBool("net", State);
            //Light1.SetActive(State);
        }
        PreviousPlayer = Player;
    }
    private void OnTriggerEnter(Collider PlayerBody)
    {
        if (PlayerBody.gameObject.name == "PlayerArmature")
        {
            Player = true;
        }
    }
    private void OnTriggerExit(Collider PlayerBody)
    {
        if (PlayerBody.gameObject.name == "PlayerArmature")
        {
            Player = false;
        }
    }

}
