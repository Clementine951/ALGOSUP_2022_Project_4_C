using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightSwitching : MonoBehaviour
{
    public GameObject Light;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
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
            Light.SetActive(State);
            Light1.SetActive(State);
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
