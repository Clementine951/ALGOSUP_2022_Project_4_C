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
        State = false;
        Light.SetActive(State);
        Light1.SetActive(State);
        Light2.SetActive(State);
        Light3.SetActive(State);
        Light4.SetActive(State);
        Light5.SetActive(State);
    }
    // Update is called once per frame
    void Update()
    {
        if (Player && Player != PreviousPlayer)
        {
            State = !State;
            Light.SetActive(State);
            Light1.SetActive(State);
            Light2.SetActive(State);
            Light3.SetActive(State);
            Light4.SetActive(State);
            Light5.SetActive(State);
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
