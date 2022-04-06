using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDetection : MonoBehaviour
{
    public GameObject card;
    //public GameObject cube;
    //public GameObject lockDoor;
    public GameObject block;

    public string tagToCompare = "AccessCard";

    // Start is called before the first frame update
    void Start()
    {
        //cube.SetActive(false);
        block.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        //card.SetActive(true);

        if (card.transform.tag == tagToCompare)
        {
            //cube.SetActive(true);
            block.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        //cube.SetActive(false);
        block.SetActive(true);
    }
}
