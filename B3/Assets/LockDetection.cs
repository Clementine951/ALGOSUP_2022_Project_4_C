using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDetection : MonoBehaviour
{
    public GameObject card;
    public GameObject cube;
    public GameObject lockDoor;

    public string tagToCompare = "AccessCard";


    public void OnTriggerEnter(Collider col)
    {
        //card.SetActive(true);

        if (col.transform.tag == tagToCompare)
        {
            cube.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        
    }

    private void Awake()
    {
        cube.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
